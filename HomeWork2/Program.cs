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

