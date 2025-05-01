using Composite.Command.Commands;

namespace Composite.Command
{
    public class CommandInvoker
    {
        private CommandHistory history;

        public CommandInvoker()
        {
            history = new CommandHistory();
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            history.Push(command);
        }

        public void Undo()
        {
            var command = history.Pop();
            if (command != null)
            {
                command.Undo();
            }
        }
    }
}
