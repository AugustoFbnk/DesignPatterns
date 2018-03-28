using Patterns.Structural.Adapter.Interfaces;

namespace Patterns.Structural.Adapter.Adapters
{
    public class Draw3DAdapter : Draw3D, IDraw
    {
        public void Draw(decimal x, decimal y, decimal z)
        {
            DrawShape(x, y, z);
        }
    }
}
