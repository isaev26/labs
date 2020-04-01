using System;
using System.Collections.Generic;
using CommandSample.Commands;
using CommandSample.ControlledSystems;

namespace CommandSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput;

            //Назначем определенной кнопке определенную команду
            remote.SetCommandForButton(1, new LightsCommand(new Light()));
            remote.SetCommandForButton(2, new ConditionerCommand(new Conditioner()));
            remote.SetCommandForButton(3, new DoorCommand(new Door()));
            
            do
            {
                Console.WriteLine("Выберите вариант ниже:");
                //Вывод созданного меню
                Console.WriteLine(remote);

                //Ввод пользователя 
                Console.Write("\nВаш выбор: ");
                var input = Console.ReadLine();
                int buttonId;
                int.TryParse(input, out buttonId);

                //вызываем методы которые выводят состояние нажатой кнопки
                remote.PushButton(buttonId);
                remote.UndoButton(buttonId);
                remote.RendoButton(buttonId);

                Console.Write("\nВы хотите продолжить (y/n): ");
                userInput = Console.ReadLine();
            } while (userInput == "y");
        }
    }
}
