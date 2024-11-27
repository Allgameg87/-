/* Написать программу, которая из имеющегося массива строк формирует
новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

System.Console.Clear();    // очищаем консоль

int max = 3;        // максимальная длинна элементов

string[] array1 = { "Hello", "2", "world", ":-)" };
Solving(array1, max);

string[] array2 = { "1234", "1567", "-2", "computer science" };
Solving(array2, max);

string[] array3 = { "Russia", "Denmark", "Kazan" };
Solving(array3, max);

// считаем количество элементов массива,длинна которых меньше и равна заданной
int CountItems(string[] arr, int max)
{
    int count = 0;                                      // инициируем счетчик
    for (int i = 0; i < arr.Length; i++)                // проверяем длинну элемента
    {
        if (arr[i].Length <= max) count++;              // увеличиваем счетчик
    }
    return count;                                       // возвращаем результат
}

// создаём новый массив и заполняем его элементами, длинна которых меньше заданной
string[] NewArray(string[] arr, int max)
{
    int newArrayLenght = CountItems(arr, max);          // узнаем, сколько элементов массива меньше заданной длинны
    string[] newArray = new string[newArrayLenght];     // создаем новый массив полученной длинны
    int newArrayIndex = 0;                              // счетчик индексов нового массива
    for (int i = 0; i < arr.Length; i++)                // перебираем исходный массив
    {
        if (arr[i].Length <= max)                       // проверяем, подходит ли элемент массива заданным условиям
        {
            newArray[newArrayIndex] = arr[i];           // копируем элемент в новый массив
            newArrayIndex++;                            // увеличиваем индекс
        }
    }
    return newArray;                                    // возвращаем новый массив
}

// выводим массив в консоль в красивом формате
void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write('"');
        System.Console.Write(array[i]);
        System.Console.Write('"');
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

// выводим итоговый результат
void Solving(string[] arr, int max)
{
    string[] newArray = NewArray(arr, max);
    PrintArray(arr);
    System.Console.Write(" → ");
    PrintArray(newArray);
    System.Console.WriteLine();
}