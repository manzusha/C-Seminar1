//Семинар 1

//Задача №1

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
Console.WriteLine("Число a большее");
Console.WriteLine("Число b меньшее");
}

else
{
Console.WriteLine("Число b большее");
Console.WriteLine("Число a меньшее");
}



//Задача №2
/*
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b) 
{
    if (a>c)
    {
    Console.WriteLine("Максимальное число a");
    }
}
if (b>a)
{
    if (b>c)
    {   
    Console.WriteLine("Максимальное число b");
    }
}

if (c>a)
{
    if (c>b)
    {   
    Console.WriteLine("Максимальное число c");
    }
}
*/


//Алтернативное решение задачи №2
/*
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());

if((a>b) && (a>c))
{   
    Console.WriteLine("Максимальное число a");
    }
if((b>a) && (b>c))
{   
    Console.WriteLine("Максимальное число b");
    }
if((c>a) && (c>b))
{   
    Console.WriteLine("Максимальное число c");
    }
*/


//Задача №3
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("Четное число");
    }

else

{
    Console.WriteLine("Нечетное число");
}
*/


//Задача №4
/*
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int c = 1;

while(c <= N)
{
    if(c % 2 == 0)
    {
    Console.Write(c + " ");
    c++;
    }
    else
    {
    c++;
    }
}
*/