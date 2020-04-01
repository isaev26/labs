using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandSample.ControlledSystems
{
    public enum DoorState
    {
        Off = 0,
        On = 1

    }
    public class Door 
    {
        public void ToggleDoor()
        {
            switch (State)
            {
                case DoorState.Off:
                    State = DoorState.On;
                    break;

                case DoorState.On:
                    State = DoorState.Off;
                    break;
            }

            PrintDoor();
        }

        public void TurnOff()
        {
            State = DoorState.Off;
            PrintDoor();
        }
        public void SetState(DoorState state)
        {
            State = state;
            PrintDoor();
        }

        public DoorState State { get; set; }

        private void PrintDoor()
        {
            switch (State)
            {
                case DoorState.On:
                    Console.WriteLine("Дверь открыта.");
                    break;

                case DoorState.Off:
                    Console.WriteLine("Дверь закрыта.");
                    break;
                    
            }
        }
    }
}
