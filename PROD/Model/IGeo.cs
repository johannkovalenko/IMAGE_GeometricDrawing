using System.Collections.Generic;
using System.Drawing;

namespace Model
{
    public interface IGeo
    {
        void Prepare(int startX, int startY, Color color, int length);
    }
}