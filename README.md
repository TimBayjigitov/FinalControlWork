# Final Control Work: Знакомство с языками программирования
## Задача : 
* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Описание алгоритма решения:
* Сначало объявляется массив: изначальный `MyArray`. Потом метод `ThreeSymbolString`, в котором создаем массив `ResultArray` в который запишутся необходимые нам данные, создается переменная `count` изначально равная 0. Далее цикл `for` внутри цикла `for` проверка условия (**<=3**), если условие выполняется, элемент массива `MyArray` заносится в `count` элемент `ResultArray` массива. После присвоения увеличивается переменная `count` на 1 и возвращается к циклу `for` в котором `i` увеличивается на 1. И так проверяется до конца.

* Графическое представление метода в папке block diagram в двух файлах разных расширениях.
* Решение программы  --> Program.cs