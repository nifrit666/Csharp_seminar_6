/*
Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Пример: 
"aBcD1eF!-" => Нет
"шалаш" => да 
"55655" => да       */

Console.WriteLine("Введите произвольную строку для проверки на палиндромность: ");
string std = Console.ReadLine();

CheckPalindrome(std);

void CheckPalindrome(string std)
{
    string revs = string.Empty;

    for (int i = std.Length - 1; i >= 0; i--)
    {
        revs += std[i];
    }

    if (revs == std)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}


// public class Task3
// {
// public static void Main(string[] args)
// {
// // Входная строка для проверки
// string input = "шалаш";
// // Вызов метода для проверки, является ли строка палиндромомbool isPalindrome = IsPalindrome(input);
// // Вывод результата
// Console.WriteLine(isPalindrome ? "Да" : "Нет");
// }
// // Метод для проверки, является ли строка палиндромомpublic static bool IsPalindrome(string str)
// {
// // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
// string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }
