using Patterns.Behavioral.Command.Interface;

namespace Patterns.Behavioral.Command.Command
{
    public class FinishCommand : ICommand
    {
        private readonly Process process;

        public FinishCommand(Process instanceProcess)
        {
            this.process = instanceProcess;
        }
        public void Execute()
        {
            process.FinishProcess();
        }
    }
}
