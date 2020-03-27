from app import *


class DoorCommandBase(CommandBase):
    def __init__(self, door):
        self.door = door


class OpenDoorCommand(DoorCommandBase):
    def execute(self):
        self.door.door_open()


class CloseDoorCommand(DoorCommandBase):
    def execute(self):
        self.door.door_close()
