// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом. 
// (Нужно использовать функцию IsPalindrome, которая принимает 
// число int или string, а возвращает bool.)
// Примеры:
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int AskAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = Math.Abs(int.Parse(Console.ReadLine()));
    return value;
}

bool ValidateNumber(int value)
{
    if (value > 99999 || value < 10000)
    {
        Console.WriteLine("Error!");
        return false;
    }
    return true;
}

bool IsPalindrome(int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10) return true;
    return false;
}

int N = AskAndGetValue("Введите число:");
if (ValidateNumber(N))
{
    if (IsPalindrome(N)) Console.WriteLine("Это палиндром.");
    else Console.WriteLine("Это не палиндром.");
}
