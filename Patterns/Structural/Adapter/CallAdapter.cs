using Patterns.Structural.Adapter.Adapters;
using Patterns.Structural.Adapter.Interfaces;

namespace Patterns.Structural.Adapter
{
    public class CallAdapter
    {
        public void Call()
        {
            IDraw draw = new Draw2DAdapter();
            draw.Draw(1, 2, 0);

            draw = new Draw3DAdapter();
            draw.Draw(1, 2, 3);
        }
    }
}
