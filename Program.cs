using Raylib_cs;
using LoggingClass;
using TileCLass;

namespace FarmMarm
{
    static class Program
    {
        static void Main(string[] args)
        {
            string title = "FarmMarm"; 
            int screenWidth = 1000;
            int screenHeight = 1000;
            int screenFps = 60;
            int tileNumber = 8;
            
            InitWindow(screenWidth, screenHeight, screenFps, title);

            Tile[,] tiles = new Tile[tileNumber, tileNumber];

            int tileWidth = screenWidth / tileNumber;
            int tileHeight = screenHeight / tileNumber;
            int tilePositionX = 0;
            int tilePositionY = 0;
            
            for (int i = 0; i < tileNumber; i++)
            {
                for (int j = 0; j < tileNumber; j++)
                {
                    tiles[i, j] = new Tile(tileWidth, tileHeight, tilePositionX, tilePositionY);
                    tilePositionX += tileWidth;
                }
                tilePositionX = 0;
                tilePositionY += tileHeight;
            }
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);

                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    int mouseX = Raylib.GetMouseX();
                    int mouseY = Raylib.GetMouseY();
                    
                    for (int i = 0; i < tileNumber; i++)
                    {
                        for (int j = 0; j < tileNumber; j++)
                        {
                            if (mouseX >= tiles[i, j].PositionX && mouseX < tiles[i, j].PositionX + tiles[i, j].Width && mouseY >= tiles[i, j].PositionY && mouseY < tiles[i, j].PositionY + tiles[i, j].Height)
                            {
                                if (!tiles[i, j].IsClicked)
                                {
                                    tiles[i, j].Color = Color.Red;
                                    tiles[i, j].IsClicked = true;
                                }
                                else
                                {
                                    tiles[i, j].Color = Color.Green;
                                    tiles[i, j].IsClicked = false;
                                }
                            }
                        }
                    }
                }

                DrawTiles(tiles);
                
                Raylib.EndDrawing();
            }

            void InitWindow(int screenWidth, int screenHeight, int screenFps, string screenTitle)
            {
                Raylib.InitWindow(screenWidth, screenHeight, screenTitle);
                Raylib.SetTargetFPS(screenFps);
                Log.Debug("Window Initialized!");
            }
            
            void DrawTiles(Tile[,] tiles)
            {
                for (int i = 0; i < tileNumber; i++)
                {
                    for (int j = 0; j < tileNumber; j++)
                    {
                        tiles[i, j].Draw();
                    }
                }
            }
        }
    }
}

// TODO: Add gitignore
// TODO: Add readme