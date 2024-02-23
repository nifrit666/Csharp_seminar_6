void Main()
{
    Console.WriteLine("Введите строку:");
    string? a = Console.ReadLine();
    char[] b = StringToCharArray(a);
    PrintArray(b);
}

char[] StringToCharArray(string? a)
{
    char[] b = new char[a!.Length];
    for (int i = 0; i < a.Length; i++)
    {
        b[i] = a[i];
    }
    return b;
}

void PrintArray(char[] b)
{
    Console.WriteLine(string.Join(", ", b));
}

Main();

﻿/*
На основе символов строки (тип string) сформировать массив символов (тип char[]).
Вывести  массив на экран.
Пример: 
"Hello!" => ['H', 'e', 'l', 'l', 'o', '!']
*/

// string st = "Hello World!";

// char[] resultArray = StringToCharArray(st);
// Console.Write($"\"{st}\" => ");

// PrintCharArray(resultArray);

// char[] StringToCharArray(string str)
// {
//     char[] chars = new char[st.Length];
//     for (int i = 0; i < st.Length; i++)
//     {
//         chars[i] = st[i];
//     }
//     return chars;
// }

// void PrintCharArray(char[] chars)
// {
//     Console.Write("[");
//     for (int i = 0; i < chars.Length; i++)
//     {
//         if (i < chars.Length - 1)
//         {
//             Console.Write($"'{chars[i]}', ");
//         }
//         else
//         {
//             Console.Write($"'{chars[i]}'");
//         }
//     }
//     Console.Write("]");
// }