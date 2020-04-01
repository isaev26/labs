using System;

namespace CommandSample.ControlledSystems
{
    public enum State //Стандартное состояние света
    {
        Off = 0,
        On = 1
    }

    public enum LightsState //Перечисление состояния в котором может находиться свет
    {
        Off = 0,
        Low = 1,
        Medium = 2,
        High = 3
    }

    public class Light //Ресивер который управляет светом
    {
        //Переключатель режима света
        public void ToggleLight()
        {
            switch (State)
            {
                case LightsState.Off:   //Если свет выключен
                    State = LightsState.Low; //Переходит в состояние тусклой яркости
                    break;

               case LightsState.Low:    //Если свет тусклый
                    State = LightsState.Medium; //То свет переходит в состояние средней яркости
                    break;

               case LightsState.Medium: //Если свет средней яркости
                    State = LightsState.High;   //То переходит в состояние яркий
                    break;

               case LightsState.High:   //Если свет яркий
                    State = LightsState.Off;//То переходит в состояние выключенный 
                    break;
            }

            PrintLight(); //Вывести свет
        }

        public void TurnOff() //Выключение света
        {
            State = LightsState.Off;
            PrintLight();
        }
        //Установка состояния лампы
        public void SetState(LightsState state)
        {
            State = state;
            PrintLight();
        }

        public LightsState State { get; set; }

        private void PrintLight()
        {
            switch (State)
            {
                case LightsState.Off:
                    Console.WriteLine("Свет выключен");
                    break;

                case LightsState.Low:
                    Console.WriteLine("Свет тусклый");
                    break;

                case LightsState.Medium:
                    Console.WriteLine("Свет средний");
                    break;

                case LightsState.High:
                    Console.WriteLine("Свет яркий");
                    break;
            }
        }
    }
}
