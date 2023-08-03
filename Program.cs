// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void SecondArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
 Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
        Console.WriteLine("]");
    
}
string[] array1 = new string[] {"1234", "1567", "2",":-)" };
string[] array2 = new string[array1.Length];
SecondArray(array1, array2);
PrintArray(array2);
string[] array3 = new string[] {"1234", "1567", "-2", "computer science" };
string[] array4 = new string[array3.Length];
SecondArray(array3, array4);
PrintArray(array4);
string[] array5 = new string[] {"Russia", "Denmark", "Kazan”" };
string[] array6 = new string[array5.Length];
SecondArray(array5, array6);
PrintArray(array6);
