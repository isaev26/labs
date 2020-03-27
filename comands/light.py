from app import *


# Уточнение команды света
class LightCommandBase(CommandBase):
    def __init__(self, light):
        self.light = light


class TurnOnLightCommand(LightCommandBase):
    def execute(self):
        self.light.turn_on()


class TurnOffLightCommand(LightCommandBase):
    def execute(self):
        self.light.turn_off()
