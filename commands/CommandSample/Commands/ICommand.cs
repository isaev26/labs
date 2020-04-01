namespace CommandSample.Commands
{
    public interface ICommand
    {
        //метод выполняющий действие
        void Execute();
        //Метод отменяющий действие
        void Undo();
        //Метод возвращающий отмененное действие 
        void Rendo();
    }
}
