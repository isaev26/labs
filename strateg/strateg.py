from random import randint


class SortCode(object):
    @staticmethod
    def show(name):
        raise NotImplementedError()


class Ascending(SortCode):
    @staticmethod
    def show(name):
        array = []
        for i in range(10):
            array.append(randint(1, 99))

        for i in range(len(array) - 1):
            m = i
            j = i + 1
            while j < len(array):
                if array[j] < array[m]:
                    m = j
                j = j + 1
            array[i], array[m] = array[m], array[i]

        print(array[:])


class Descending(SortCode):
    @staticmethod
    def show(name):
        array = []
        for i in range(10):
            array.append(randint(1, 99))

        for i in range(len(array) - 1):
            m = i
            j = i + 1
            while j < len(array):
                if array[j] > array[m]:
                    m = j
                j = j + 1
            array[i], array[m] = array[m], array[i]

        print(array[:])


class Sorting(object):
    @classmethod
    def pick(cls, name):
        ext = name
        if ext == 'ascending':
            decoder = Ascending
        elif ext in ('descending'):
            decoder = Descending
        else:
            raise RuntimeError('Невозможно сортироват %s' % name)
        byterange = decoder.show(name)
        return cls(byterange, name)

    def __init__(self, byterange, name):
        self._byterange = byterange
        self._name = name


print("ascending ->")
Sorting.pick('ascending')
print('descending ->')
Sorting.pick('descending')

str = input("Выберите: ")

Sorting.pick(str)
