using Patterns.Behavioral.Command.Command;
using Patterns.Behavioral.Command.Invoker;

namespace Patterns.Behavioral.Command
{
    public class CallCommand
    {
        public void Call()
        {
            var invoker = new InvokeAction();
            var process = new Process();

            var commandBegin = new StartCommand(process);
            invoker.SetCommand(commandBegin);
            invoker.Invoke();

            var commandEnd = new FinishCommand(process);
            invoker.SetCommand(commandEnd);
            invoker.Invoke();
        }
    }

}
