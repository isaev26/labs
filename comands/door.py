from app import *


# Инициализация команды
class DoorCommandBase(CommandBase):
    def __init__(self, door):
        self.door = door


# Уточнение команды двери
class OpenDoorCommand(DoorCommandBase):
    def execute(self):
        self.door.door_open()


class CloseDoorCommand(DoorCommandBase):
    def execute(self):
        self.door.door_close()
