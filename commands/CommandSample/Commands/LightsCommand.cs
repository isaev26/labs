using System.Collections.Generic;
using CommandSample.ControlledSystems;

namespace CommandSample.Commands
{
    public class LightsCommand : ICommand
    {
        int count;  //Переменная содержит количество отмененных действий
        private Light _light;
        //Используем коллекцию стек для того чтобы возвращаться к прошлому состоянию
        private Stack<LightsState> _states;

        //В конструктор передается объект класса "Свет"это сделано для того 
        //чтобы управлять светом к примеру не только во всем доме, 
        //но и в разных комнатах, для этого достаточно подменить класс "Свет"
        public LightsCommand(Light light)
        {
            _light = light;
            _states = new Stack<LightsState>();
            count = -1;
        }

        public void Execute()
        {
            //помещаем состояние в стек
            _states.Push(_light.State);
            //Переходим в конкретное состояние 
            _light.ToggleLight();
        }

        public void Undo()
        {
            if (_states.Count != 0)
            {
                //Достаем из стека предыдущее состояние света
                var prevState = _states.Pop();
                //Выводим состояние 
                _light.SetState(prevState);
                count++;
            }
        }
        public void Rendo()
        {
            while (count > -1)
            {
                _states.Push(_light.State);
                _light.ToggleLight();
                count--;
            }
        }
        //Переопределяем метод, для выведения некоторого строкого представление объекта
        public override string ToString()
        {
            return "Включить свет";
        }
    }
}
