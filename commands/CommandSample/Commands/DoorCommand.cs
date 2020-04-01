using System;
using System.Collections.Generic;
using CommandSample.ControlledSystems;

namespace CommandSample.Commands
{
    public class DoorCommand : ICommand
    {
        int count;
        private Door _Door;
        private Stack<DoorState> _states;
        public DoorCommand(Door door)
        {
            _Door = door;
            _states = new Stack<DoorState>();
            count = -1;
        }

        public void Execute()
        {
            _states.Push(_Door.State);
            _Door.ToggleDoor();
        }

        public void Undo()
        {
            if (_states.Count != 0)
            {
                var prevState = _states.Pop();
                _Door.SetState(prevState);
                count++;
            }
        }
        public void Rendo()
        {
            while (count > -1)
            {
                _states.Push(_Door.State);
                _Door.ToggleDoor();
                count--;
            }
        }
        public override string ToString()
        {
            return "Открыть дверь.";
        }
    }
}
