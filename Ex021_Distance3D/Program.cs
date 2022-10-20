// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// Примеры:
// A(3,6,8); B(2,1,-7) -> 15.84
// A(7,-5,0); B(1,-1,9) -> 11.53

int AskAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

double GetDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
    return result;
}

int[] PointA = { AskAndGetValue("Введите Х1:"), AskAndGetValue("Введите Y1:"), AskAndGetValue("Введите Z1:") };
int[] PointB = { AskAndGetValue("Введите Х2:"), AskAndGetValue("Введите Y2:"), AskAndGetValue("Введите Z2:") };

double distance = GetDistance(PointA[0],PointA[1],PointA[2],PointB[0],PointB[1],PointB[2]);

Console.Write("Расстояние между точками: ");
Console.Write(Math.Round(distance, 2));
