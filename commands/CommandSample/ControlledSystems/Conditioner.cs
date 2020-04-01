using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandSample.ControlledSystems
{
    public enum ConditionerState 
    {
        Off = 0,
        Low = 1,
        Medium = 2,
        High = 3
    }
    public class Conditioner 
    {
        public void ToggleConditioner()
        {
            switch (State)
            {
                case ConditionerState.Off: 
                    State = ConditionerState.Low;
                    break;

                case ConditionerState.Low:  
                    State = ConditionerState.Medium; 
                    break;

                case ConditionerState.Medium:
                    State = ConditionerState.High; 
                    break;

                case ConditionerState.High:   
                    State = ConditionerState.Off;
                    break;
            }

            PrintConditioner(); 
        }

        public void TurnOff() 
        {
            State = ConditionerState.Off;
            PrintConditioner();
        }
        public void SetState(ConditionerState state)
        {
            State = state;
            PrintConditioner();
        }

        public ConditionerState State { get; set; }

        private void PrintConditioner()
        {
            switch (State)
            {
                case ConditionerState.Off:
                    Console.WriteLine("Кондиционер выключен.");
                    break;

                case ConditionerState.Low:
                    Console.WriteLine("Низкая скорость.");
                    break;

                case ConditionerState.Medium:
                    Console.WriteLine("Средняя скорость.");
                    break;

                case ConditionerState.High:
                    Console.WriteLine("Высокая скорость.");
                    break;
            }
        }
    }
}
