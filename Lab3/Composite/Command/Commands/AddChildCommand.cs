﻿namespace Composite.Command.Commands
{
    public class AddChildCommand : ICommand
    {
        private readonly LightElementNode parent;
        private readonly LightNode child;

        public AddChildCommand(LightElementNode parent, LightNode child)
        {
            this.parent = parent;
            this.child = child;
        }

        public void Execute()
        {
            parent.AddChild(child);
        }

        public void Undo()
        {
            parent.RemoveChild(child);
        }
    }
}
