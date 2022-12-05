// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
/*
int Method(int twoNum)
{
    int a = twoNum % 100;
    int result = a / 10;
    return result;
}

Console.Write("Введите трех-значное число: ");
Console.WriteLine(Method(Convert.ToInt32(Console.ReadLine())));
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 1 Способ
/*
int Lenght(int number)
{
    int lenght = 0;
    while(number > 0)
    {
        number = number / 10;
        lenght++;
    }
    return lenght;
}

string Method(int number)
{
    int lenght = 0;
    lenght = Lenght(number);
    if(lenght > 2)
    {
        while(number > 1000)
        {
            number = number / 10;
        }
        number = number % 10;
        return $"Третье число {number}";
    }
    else
    {
        return "Нет третьего числа.";
    }
}
Console.Write("Введите число: ");
Console.WriteLine(Method(Convert.ToInt32(Console.ReadLine())));
*/

// 2 Способ

/*
string Method(int number)
{
    string num = Convert.ToString(number);
    if(num.Length > 2)
    {
        return $"Третье число {num[2]}";
    }
    else
    {
        return "Нет третьего числа.";
    }
}
Console.Write("Введите число: ");
Console.WriteLine(Method(Convert.ToInt32(Console.ReadLine())));
/*

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 1 Вариант
/*
bool Method(int number)
{
    if(number <= 5 && number > 0)
    {
        return false;
    }
    if(number > 5 && number <= 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.Write("Введите число от 1 до 7: ");
Console.WriteLine(Method(Convert.ToInt32(Console.ReadLine())));
*/

// 2 Вариант

/*
bool Method(int number)
{
    switch(number)
    {
        case 1:
            return false;
        case 2:
            return false;
        case 3: 
            return false;
        case 4: 
            return false;
        case 5:
            return false;
        case 6:
            return true;
        case 7:
            return true;
        default:
            return false;
    }
}
Console.Write("Введите число от 1 до 7: ");
Console.WriteLine(Method(Convert.ToInt32(Console.ReadLine())));
*/