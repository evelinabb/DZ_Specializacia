// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"]-> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"]-> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] ChangedArray(string[] array)
{
    string[] massiv = new string[array.Length];
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        string str = array[i];
        if (str.Length <= 3)
        {
            massiv[n] = array[i];
            n++;
        }
    }
    Array.Resize(ref massiv, n);

    return massiv;
}

void PrintArray(string[] massiv)
{
    Console.Write("[");
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"\"{massiv[i]}\"");
        if (i < massiv.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}



string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

PrintArray(array1);
string[] array1Changed = ChangedArray(array1);
System.Console.Write( " -> ");
PrintArray(array1Changed);
System.Console.WriteLine();

PrintArray(array2);
string[] array2Changed = ChangedArray(array2);
System.Console.Write( " -> ");
PrintArray(array2Changed);
System.Console.WriteLine();

PrintArray(array3);
string[] array3Changed = ChangedArray(array3);
System.Console.Write( " -> ");
PrintArray(array3Changed);