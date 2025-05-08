using Raylib_cs;
using LoggingClass;

namespace TileCLass;

public class Tile
{
    
    public int Width { get; set; }
    public int Height { get; set; }
    public int PositionX;
    public int PositionY;
    public Color Color = Color.Green;
    public bool IsClicked = false;

    public Tile(int width, int height, int positionX, int positionY)
    {
        this.Width = width;
        this.Height = height;
        this.PositionX = positionX;
        this.PositionY = positionY;
    }

    public void Draw()
    {
        Raylib.DrawRectangle(PositionX, PositionY, Width, Height, Color);
        Raylib.DrawRectangleLines(PositionX, PositionY, Width, Height, Color.White);
    }
}