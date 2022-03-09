//Задача № 19. Определить является ли пятизначное число палиндромом.
/*
void Pallindrom(int n)
{
    if (n >= 10000 && n < 100000)
    {
        int number = n;

        int digit5 = number % 10;
        number /= 10;
        int digit4 = number % 10;
        number /= 10;
        number /= 10;
        int digit2 = number % 10;
        number /= 10;
        int digit1 = number % 10;
     
        if (digit5 == digit1 && digit4 == digit2) Console.WriteLine("Палиндром");
        else Console.WriteLine("Не является палиндромом");
    }

    else
    {
        Console.WriteLine("Введите пятизначное число");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Pallindrom(n);
*/




//Задача №21. Расчет расстояния между двумя точками в 3D
/*
double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;

    double result = Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
    return result;
}

double xA, yA, zA, xB, yB, zB;
double distance;

Console.Write("Input X of Point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of Point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of Point A: ");
zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input X of Point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of Point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of Point B: ");
zB = Convert.ToDouble(Console.ReadLine());

distance = GetDistance (xA, xB, yA, yB, zA, zB);
Console.WriteLine(distance);
*/




//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел.
/*
void Cube(int number)
{
    int n = number;
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i * i + " ");
    }
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);
*/