using System.Drawing;

public class Pixel
{
    public readonly int x;
    public readonly int y;
    public readonly Color color;

    public Pixel(int x, int y, Color color)
    {
        this.x = x;
        this.y = y;
        this.color = color;
    }
}