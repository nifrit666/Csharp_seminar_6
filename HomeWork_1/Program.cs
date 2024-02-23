/*
Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

Пример: 
a b c   =>  "abcdef"
d e f 
*/

char[,] ch = {
    {'a', 'b', 'c',},
    {'d', 'e', 'f'}
    };

Console.WriteLine(CreateStringOfSymbol(ch));

string CreateStringOfSymbol(char[,] ch)
{
    string str = string.Empty; //пустая строка 

    for (int i = 0; i < ch.GetLength(0); i++)
    {
        for (int j = 0; j < ch.GetLength(1); j++)
        {
            str += ch[i, j];
        }
    }

    return str;
}

// // Задача 1: Создание строки из двумерного массива символов
// public class Task1
// {
// public static void Main(string[] args)
// {
// // Инициализация двумерного массива символов
// char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
// // Вызов метода для создания строки из 2D массива
// string result = CreateStringFrom2DArray(charArray);
// // Вывод результата
// Console.WriteLine(result);
// }
// // Метод для создания строки из двумерного массива символов
// public static string CreateStringFrom2DArray(char[,] array)
// {
// string result = "";
// // Цикл по каждому элементу в двумерном массиве
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// // Добавление каждого символа в результирующую строку
// result += array[i, j];
// }
// }
// return result;
// }
// }