// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SelectNumber(int number)
{
    int result = 0;

    if(number > 99 && number < 1000)
    {
        int sot = number / 10;
        int ed = sot % 10;
        result = ed;
        Console.WriteLine("Second number of your three-digit number:");
    }
    else
    {
        result = -1; 
        Console.WriteLine("Error! Your number is not correct!");
    }

    return result;
} 

Console.Write("Input a three-digit number: ");
int numb = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine(SelectNumber(numb));
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdNumber(int number)
{
    int result = 0;

    if(number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    else
    {
        result = -1;
        Console.WriteLine("No third digit");
    }

    return result;
}

Console.WriteLine("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ThirdNumber(numb));
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool week(int day)
{
    
    if(day < 8 && day > 0)
    {
        if(day > 5)
    {
        Console.WriteLine("Hurray! Day off!");
        return true;
    }
    else
    {
        Console.WriteLine("Work!");
        return false;
    }
    }
    else
    {
        
        Console.WriteLine("The days of the week are counted from 1 to 7. Try again.");
        return false;
    }
    
}

Console.WriteLine("Input a  day of the week: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(week(DayWeek));
*/