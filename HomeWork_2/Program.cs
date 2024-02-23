// ﻿/*
// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Пример: 
// "aBcD1Ef!-" => "abcd1ef!-"
// */

void StringLower(string str)
{
    str = str.ToLower();
    Console.WriteLine(str);
}

Console.WriteLine("Введите строку из латинских букв: ");
string str = Console.ReadLine();

StringLower(str);

// public class Task2
// {
// public static void Main(string[] args)
// {
// // Входная строка со смешанными буквами обоих регистровstring input = "aBcD1ef!-";
// // Преобразование всех заглавных букв в строчные
// string result = input.ToLower ();
// // Вывод результата
// Console.WriteLine(result);
// }
// }