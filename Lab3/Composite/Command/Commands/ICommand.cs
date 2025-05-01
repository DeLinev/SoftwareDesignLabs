namespace Composite.Command.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
