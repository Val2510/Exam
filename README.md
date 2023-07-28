Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение:
Шаг 1: string[] ArrayRand
Просим пользователя ввести с клавиатуры первоначальный массив. Каждый элемент массива вводится отдельно под 
изначательно заданный размер (5 элементов).

Шаг 2:string[] Characters
С помощью метода Characters сначала ищем какие из введенных пользователем элементов имеют количество символов
меньше или равно 3. Затем создаем новый массив string[] result и кладем в него элементы, размер которых 3 и меньше. 

![Блок-схема](https://github.com/Val2510/Exam/blob/main/БС.png)


Шаг 3: void PrintArray
С помощью метода PrintArray печатаем новый массив.
