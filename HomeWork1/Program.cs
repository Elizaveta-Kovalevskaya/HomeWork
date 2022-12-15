// Домашняя Работа 1.

// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2)
{
    Console.WriteLine("max = " + num2);
    Console.WriteLine("min = " + num1);
}
else
{
    Console.WriteLine("max = " + num1);
    Console.WriteLine("min = " + num2);
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2)
{
   if(num2 < num3)
   {
     Console.Write("max = " + num3);

    }
    else
    {
     Console.Write("max = " + num2);
    }
}
else
{
    if(num1 < num3)
    {
        Console.Write("max = " + num3);
    }
    else
    {
        Console.Write("max = " + num1);
    }
}
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Inbut number: ");
int numb = Convert.ToInt32(Console.ReadLine());
 
 
if(numb % 2==0) 
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
int a = 1;


while( a <= numb) 
{
    if(a % 2 == 0)
    {
      Console.WriteLine(a);
      a = a + 1;
    }
    else
    {
       a = a + 1;
    }
}
*/