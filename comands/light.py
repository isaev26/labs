from app import *


# Инициализация команды
class LightCommandBase(CommandBase):
    def __init__(self, light):
        self.light = light


# Уточнение команды света
class TurnOnLightCommand(LightCommandBase):
    def execute(self):
        self.light.turn_on()


class TurnOffLightCommand(LightCommandBase):
    def execute(self):
        self.light.turn_off()
