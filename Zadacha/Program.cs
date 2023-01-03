// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Дан массив из случайных строк: ");
string[] basearray = {"№", "GeekBrains", "GB", "001", "1"};
string[] newarray = new string[basearray.Length];

NewArray(basearray, newarray);
PrintArray(basearray);
System.Console.WriteLine("Тот же массив, где строки меньше трех символов: ");
PrintArray(newarray);

void NewArray(string[] basearray, string[] newarray)
{
    int element = 0;
    for (int i = 0; i < basearray.Length; i++)
    {
    if(basearray[i].Length <= 3)
        {
        newarray[element] = basearray[i];
        element++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


