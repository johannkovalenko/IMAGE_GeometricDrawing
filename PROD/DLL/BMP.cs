using System.Drawing;

namespace JK.Tools.Drawing
{
    public interface BMP
    {
        Color GetPixel(int x, int y);
        void SetPixel(int x, int y, Color color);
        void Save(string file);
    }
}