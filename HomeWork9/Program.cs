//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNaturalNumbers (int n)
{
  Console.Write(n + " ");
  if(n > 1) ShowNaturalNumbers(n - 1);
}

ShowNaturalNumbers(10);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNaturalsElements(int m, int n)
{
    
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m + 1)) / 2;       
    else if (m == n) return m;                       
    else if (m < n) return n + SumNaturalsElements (m, n - 1); 
    else return n + SumNaturalsElements (m, n + 1);            
}

Console.WriteLine(SumNaturalsElements(15, 1));
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
Console.Write(Ackermann(2,3));
*/