from abc import ABC, abstractmethod


class AbstractClass(ABC):

    def template_method(self):

        self.base_operation1()
        self.required_operations()
        self.cook1()
        self.base_operation2()
        self.cook2()
        self.base_operation3()

    def base_operation1(self):
        print("Поймал")

    def base_operation2(self):
        print("Съел")

    def base_operation3(self):
        print("Уснул")

    @abstractmethod
    def required_operations(self):
        pass

    def cook1(self):
        pass


class ConcreteClass1(AbstractClass):
    
    def required_operations(self):
        pass

    def cook1(self):
        print("Жарил")


class ConcreteClass2(AbstractClass):

    def required_operations(self):
        print("Пообщался")

    def cook1(self):
        print("Варил")


def client_code(abstract_class: AbstractClass):

    abstract_class.template_method()


if __name__ == "__main__":
    print("Агресивный канибал:")
    client_code(ConcreteClass1())
    print("")

    print("Интелегетный:")
    client_code(ConcreteClass2())
