using System;
using Patterns.Structural.Adapter.Interfaces;

namespace Patterns.Structural.Adapter.Adapters
{
    public class Draw2DAdapter : Draw2D, IDraw
    {
        public void Draw(decimal x, decimal y, decimal z)
        {
            DrawShape(x, y);
        }
    }
}
