using Patterns.Behavioral.Command.Interface;

namespace Patterns.Behavioral.Command.Invoker
{
    public class InvokeAction
    {
        private ICommand command;

        public void SetCommand(ICommand instanceCommand)
        {
            this.command = instanceCommand;
        }

        public void Invoke()
        {
            command.Execute();
        }
    }
}
