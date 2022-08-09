/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
*/
Console.Clear();
string[] array = new string[] { "qqq", "wwww", "1234", "&", "%%%" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void RE_arr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
    }
        else arr[i] = string.Empty;
    }
}
PrintArray(array);
RE_arr(array);
Console.Write("Итог: ");
PrintArray(array);