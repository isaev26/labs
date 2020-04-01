using System;

namespace AbstracFactory
{
    // Интерфейс Абстрактной Фабрики объявляет набор методов, которые возвращают
    // различные абстрактные продукты. Продукты одного семейства
    // обычно могут взаимодействовать между собой.
    public interface IAbstracFactory
    {
        IAbstracCommander CreateCommander();
        IAbstracGeneral CreaterGenereal();
        IAbstracSoldier CreateSoldier();
    }

    // Конкретная Фабрика производит семейство продуктов одной вариации.
    class FactoryOfGnome : IAbstracFactory
    {
        public IAbstracCommander CreateCommander()
        {
            return new GnomeCommander();
        }

        public IAbstracGeneral CreaterGenereal()
        {
            return new GnomeGeneral();
        }

        public IAbstracSoldier CreateSoldier()
        {
            return new GnomeSoldier();
        }

    }
    // Конкретная Фабрика производит семейство продуктов одной вариации.
    class FactoryOfElf : IAbstracFactory
    {
        public IAbstracCommander CreateCommander()
        {
            return new ElfCommander();
        }

        public IAbstracGeneral CreaterGenereal()
        {
            return new ElfGeneral();
        }

        public IAbstracSoldier CreateSoldier()
        {
            return new ElfSoldier();
        }

    }

    // Каждый отдельный продукт семейства продуктов должен имеет базовый
    // интерфейс.
    public interface IAbstracCommander
    {
        string UsefulFunctionCommander();
    }

    // Конкретные Продукты создаются соответствующими Конкретными Фабриками.
    class GnomeCommander : IAbstracCommander
    {
        public string UsefulFunctionCommander()
        {
            return "Gnome Commandor";
        }
    }

    class ElfCommander: IAbstracCommander
    {
        public string UsefulFunctionCommander()
        {
            return "Elf Commandor";
        }
    }
    // Все продукты могут взаимодействовать
    // друг с другом, но правильное взаимодействие возможно только между
    // продуктами одной и той же конкретной вариации.
    public interface IAbstracGeneral
    {
        // Продукт General способен работать самостоятельно...
        string UsefulFunctionGeneral();
        // Продукт GnomeGeneral может корректно работать только с Продуктом GnomeCommander. Тем не
        // менее, он принимает любой экземпляр Абстрактного Продукта GnomeCommander в
        // качестве аргумента.
        string AnotherUsefulGeneral(IAbstracCommander collaborator);
    }

    class GnomeGeneral : IAbstracGeneral
    {
        public string UsefulFunctionGeneral()
        {
            return "Gnome General";
        }

        public string AnotherUsefulGeneral(IAbstracCommander collaborator)
        {
            var result = collaborator.UsefulFunctionCommander();

            return $"  The gnome general salutes the ({result})";
        }
    }

    class ElfGeneral : IAbstracGeneral
    {
        public string UsefulFunctionGeneral()
        {
            return "Elf General";
        }

        public string AnotherUsefulGeneral(IAbstracCommander collaborator)
        {
            var result = collaborator.UsefulFunctionCommander();

            return $"  The elf general salutes the ({result})";
        }

    }

    public interface IAbstracSoldier
    {
        string UsefulFunctionSoldier();

        string AnotherUsefulSoldier(IAbstracGeneral collaborator);
    }

    class GnomeSoldier : IAbstracSoldier
    {
        public string UsefulFunctionSoldier()
        {
            return "Gnome Soldier";
        }

        public string AnotherUsefulSoldier(IAbstracGeneral collaborator)
        {
            var result = collaborator.UsefulFunctionGeneral();

            return $"  The gnome soldier salutes the ({result})";
        }
    }

    class ElfSoldier : IAbstracSoldier
    {
        public string UsefulFunctionSoldier()
        {
            return "Elf Soldier";
        }

        public string AnotherUsefulSoldier(IAbstracGeneral collaborator)
        {
            var result = collaborator.UsefulFunctionGeneral();

            return $"  The gnome soldier salutes the ({result})";
        }
    }

    // типы: Абстрактная Фабрика и Абстрактный Продукт. Это позволяет передавать
    // любой подкласс фабрики или продукта клиентскому коду, не нарушая его.
    class Client
    {
        public void Main()
        {
            // Клиентский код может работать с любым конкретным классом фабрики.
            Console.WriteLine("Gnome: Testing factory create gnome... ");
            ClientMethod(new FactoryOfGnome());
            Console.WriteLine();

            Console.WriteLine("Elf: Testing factory create elf... ");
            ClientMethod(new FactoryOfElf());
        }

        public void ClientMethod(IAbstracFactory factory)
        {
            var commander = factory.CreateCommander();
            var general = factory.CreaterGenereal();
            var soldier = factory.CreateSoldier();

            Console.WriteLine(commander.UsefulFunctionCommander());
            Console.WriteLine(general.UsefulFunctionGeneral());
            Console.WriteLine(general.AnotherUsefulGeneral(commander));
            Console.WriteLine(soldier.UsefulFunctionSoldier());
            Console.WriteLine(soldier.AnotherUsefulSoldier(general));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
