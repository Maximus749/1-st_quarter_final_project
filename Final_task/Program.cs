// Задача: Написать программу, которая принимает из имеющегося массива строк, формирует массив из строк, длина которых
// меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатеры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void PrintArray(string[] array)
{
    Console.Write("[");
    foreach (string str in array)
    {
        Console.Write($"{str} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
string[] ModifyArray(string[] arr1)
{
    int count = 0;
    foreach (string str in arr1)
    {
        if (str.Length <= 3) count ++;
    }
    string[] arr2 = new string[count];
    int k = 0;
    foreach (string str in arr1)
    {
        if (str.Length <= 3)
        {
            arr2[k] = str;
            k ++;
        }
    }
    return arr2;
}
string[] words = {"hello", "2", "223", "22", "world", ":-)"};
// string[] words = {"hello", "world"};
PrintArray(words);
string[] array2 = ModifyArray(words);
PrintArray(array2);
