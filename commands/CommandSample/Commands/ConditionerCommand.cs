using System;
using System.Collections.Generic;
using CommandSample.ControlledSystems;

namespace CommandSample.Commands
{
    public class ConditionerCommand : ICommand
    {
        int count; 
        private Conditioner _conditioner;
        private Stack<ConditionerState> _states;
        public ConditionerCommand(Conditioner conditioner)
        {
            _conditioner = conditioner;
            _states = new Stack<ConditionerState>();
            count = -1;
        }

        public void Execute()
        {
            _states.Push(_conditioner.State);
            _conditioner.ToggleConditioner();
        }

        public void Undo()
        {
            if (_states.Count != 0)
            {
                var prevState = _states.Pop();
                _conditioner.SetState(prevState);
                count++;
            }
        }
        public void Rendo()
        {
            while (count > -1)
            {
                _states.Push(_conditioner.State);
                _conditioner.ToggleConditioner();
                count--;
            }
        }
        public override string ToString()
        {
            return "Включить кондиционер.";
        }
    }
}
