using Patterns.Behavioral.Command.Interface;

namespace Patterns.Behavioral.Command.Command
{
    public class StartCommand : ICommand
    {
        private readonly Process process;

        public StartCommand(Process instanceProcess)
        {
            this.process = instanceProcess;
        }
        public void Execute()
        {
            process.StartProcess();
        }
    }
}
