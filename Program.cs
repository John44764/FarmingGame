using Raylib_cs;
using LoggingClass;

namespace FarmMarm
{
    static class Program
    {
        static void Main(string[] args)
        {
            string screenTitle = "FarmMarm";
            int screenWidth = 1000;
            int screenHeight = 1000;
            int screenFps = 60;
            
            Raylib.InitWindow(screenWidth, screenHeight, screenTitle);
            Raylib.SetTargetFPS(screenFps);
            Log.Debug("Window Initialized!");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                
                DrawGrid(25, screenWidth, screenHeight);
                
                Raylib.EndDrawing();
            }

            static void DrawGrid(double numberOfCells, int screenWidth, int screenHeight)
            {
                try
                {
                    if (Math.Sqrt(numberOfCells) % 1 != 0 || numberOfCells < 0)
                    {
                        throw new System.Exception("Invalid number of cells");
                    }
                    int cellsSqrt = (int)Math.Sqrt(numberOfCells);

                    int numberOfCellsX, numberOfCellsY;
                    numberOfCellsX = numberOfCellsY = cellsSqrt;
                    
                    int cellWidth = screenWidth / numberOfCellsX;
                    int cellHeight = screenHeight / numberOfCellsY;
                
                    int rectPosX = 0;
                    int rectPosY = 0;
                    
                    for (int i = 0; i < cellsSqrt; i++)
                    {
                        for (int j = 0; j < cellsSqrt; j++)
                        {
                            Raylib.DrawRectangle(rectPosX, rectPosY, cellWidth, cellHeight, Color.Green);
                            Raylib.DrawRectangleLines(rectPosX, rectPosY, cellWidth, cellHeight, Color.White);
                            
                            rectPosX += cellWidth;
                        }
                        rectPosY += cellHeight;
                        rectPosX = 0;
                    }
                }
                catch (Exception e)
                {
                    Log.Exeption(e);
                    Log.Error(e.Message);
                    throw;
                }
                
            }
        }
    }
}

// TODO: Add gitignore
// TODO: Add readme