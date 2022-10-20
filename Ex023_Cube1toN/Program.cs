// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// Примеры:
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int AskAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int N = AskAndGetValue("Введите целое число:");

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        if (i < N)
        {
            Console.Write(Math.Pow(i, 3) + ", ");
        }
        else Console.Write(Math.Pow(i, 3));
    }
}
else
{
    for (int i = N; i < 0; i++)
    {
        if (i < -1)
        {
            Console.Write(Math.Pow(i, 3) + ", ");
        }
        else Console.Write(Math.Pow(i, 3));
    }
}
