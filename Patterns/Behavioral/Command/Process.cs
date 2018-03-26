namespace Patterns.Behavioral.Command
{
    public class Process
    {
        private bool inProcess;

        public void StartProcess()
        {
            inProcess = true;
        }
        public void FinishProcess()
        {
            inProcess = false;
        }
    }
}
