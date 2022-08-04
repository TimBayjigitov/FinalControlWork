/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] MyArray = new string[5] { "1234", "1567", "-2", "computer science", ":-)" };

string[] ThreeSymbolString(string[] array) // Метод решения программы
{
    string[] ResultArray = new string[array.Length]; // Массив в который запишем необходимые нам элементы
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) // Проверка элемента на колличество символов (в нашем случае должно быть меньше либо равно 3 символам))
        {
            ResultArray[count] = array[i];
            count++;
        }
    return ResultArray;
}

void ShowArray(string[] array) // Метод вывода массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}