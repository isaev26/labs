class App(object):
    def turn_on(self):
        print('Свет включен')

    def turn_off(self):
        print("Свет выключен")

    def door_open(self):
        print("Дверь открыто")

    def door_close(self):
        print("Дверь закрыто")


# Интерфейс команды
class CommandBase(object):
    def execute(self):
        raise NotImplementedError()
