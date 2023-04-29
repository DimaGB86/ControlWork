// Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Решение:

string[] CreateStringArray()
{
    Console.WriteLine("Введите количество элементов в массиве: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] stringArray = new string[size];
    int i = 0;
    while(i < size)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        string? element = Console.ReadLine()??String.Empty;
        stringArray[i] = element;
        i++;
    }
    return stringArray;
}


string[] LessThenThreeSymbols(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


string[] myArray = CreateStringArray();
string[] myArray2 = LessThenThreeSymbols(myArray);
ShowArray(myArray);
Console.WriteLine("");
ShowArray(myArray2);