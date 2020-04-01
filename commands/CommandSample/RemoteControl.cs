 using System;
using System.Collections.Generic;
using System.Text;
using CommandSample.Commands;

namespace CommandSample
{
    public class RemoteControl
    {
        private Dictionary<int, ICommand> _commands;

        public RemoteControl()
        {
            _commands = new Dictionary<int, ICommand>();
        }

        //Передаем в качестве параметра кнопку 
        public void PushButton(int buttonId)
        {
            if (_commands.ContainsKey(buttonId))
                _commands[buttonId].Execute();
        }

        //Операция отмены (откатиться назад)
        public void UndoButton(int buttonId)
        {
            if (_commands.ContainsKey(buttonId))
                _commands[buttonId].Undo();
        }
        public void RendoButton(int buttonId)
        {
            if (_commands.ContainsKey(buttonId))
                _commands[buttonId].Rendo();
        }
        //Метод назначения команды на кнопку
        public void SetCommandForButton(int buttonId, ICommand cmd)
        {
            _commands[buttonId] = cmd; //Если ключ не существует он автоматически его добавит, а если ключ существует то он его перезапишет 
        }

        //Выводим меню
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var buttonId in _commands.Keys)
                sb.AppendFormat("{0} \t- {1}\n", buttonId, _commands[buttonId]);

            sb.Append("проч. \t- Выход");

            return sb.ToString();
        }
    }
}
