//Задача 10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void FindNumb(int num)
{
    if(num >= 100 && num < 1000)
    {
        Console.WriteLine("Вторая цифра " + num / 10 % 10);
        }

    else
    {
        Console.WriteLine("Введите трехзначное число");
        }
}

FindNumb(num);
*/


//Задача 13. 
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void FindNumb(int num)
{
    if(num < 100)
    {
        Console.WriteLine("Третье цифры нет");
        }

    else {
        while(num >=1000) {
            num /= 10;
        }

        Console.WriteLine("Третья цифра " + num % 10);
        }
            
    
}

FindNumb(num);
*/


//Задача 15. 
/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

int DayOff(int num)

{
    if (num == 1)
    {
        Console.WriteLine("Понедельник");
        return num;
    }

    if (num == 2)
    {
        Console.WriteLine("Вторник");
        return num;
    }

    if (num == 3)
    {
        Console.WriteLine("Среда");
    }

    if (num == 4)
    {
        Console.WriteLine("Четверг");
    }

    if (num == 5)
    {
        Console.WriteLine("Пятница");
    }

    if (num == 6)
    {
        Console.WriteLine("Суббота");
    }

    if (num == 7)
    {
        Console.WriteLine("Воскресенье");
    }
    return num;
}

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 7 && num >= 1)
{
    DayOff(num);
}

else
{
    Console.WriteLine("Такого дня недели не существует");
}
*/