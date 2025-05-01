using Composite.Command.Commands;

namespace Composite.Command
{
    public class CommandHistory
    {
        private Stack<ICommand> executedCommands;

        public CommandHistory()
        {
            executedCommands = new Stack<ICommand>();
        }

        public void Push(ICommand command)
        {
            executedCommands.Push(command);
        }

        public ICommand? Pop()
        {
            if (executedCommands.Count > 0)
            {
                return executedCommands.Pop();
            }

            return null;
        }
    }
}
