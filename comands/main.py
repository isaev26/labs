from app import *
from light import *
from door import *

# Переключател


class Switch(object):
    def __init__(self, on_cmd, off_cmd):
        self.on_cmd = on_cmd
        self.off_cmd = off_cmd

    # выкл
    def on(self):
        self.on_cmd.execute()
    # Выкл

    def off(self):
        self.off_cmd.execute()


light = App()
door = App()
# switch = Switch(on_cmd=TurnOnLightCommand(light), off_cmd=TurnOffLightCommand(light))
# print("1. Свет \n 2. Двер")
# Управленеи
while True:
    com = input("1. Свет \n2. Двер\n$-->")
    if com == "1":
        switch = Switch(on_cmd=TurnOnLightCommand(light),
                        off_cmd=TurnOffLightCommand(light))
        select = input("Свет:\n  1. Включить \n  2. Выключить\n$-->")
        if select == "1":
            switch.on()
        elif select == "2":
            switch.off()
    elif com == "2":
        switch = Switch(on_cmd=OpenDoorCommand(door),
                        off_cmd=CloseDoorCommand(door))
        select = input("Дверь:\n  1. Открыть \n  2. Закрыть\n$-->")
        if select == "1":
            switch.on()
        elif select == "2":
            switch.off()
