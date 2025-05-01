namespace Composite.Command.Commands
{
    public class MakeActiveCommand : ICommand
    {
        private readonly LightElementNode element;
        private readonly string activeClassName;

        public MakeActiveCommand(LightElementNode element, string activeClassName)
        {
            this.element = element;
            this.activeClassName = activeClassName;
        }

        public void Execute()
        {
            if (!element.CssClasses.Contains(activeClassName))
            {
                element.AddCssClass(activeClassName);
            }
        }

        public void Undo()
        {
            element.RemoveCssClass(activeClassName);
        }
    }
}
