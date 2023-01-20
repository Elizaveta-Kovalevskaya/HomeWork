//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int AboveZiro(int size)
{
  int count = 0;
  for(int m = 0; m < size; m++)
  {
    Console.Write($"Input a number {m + 1}: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if(n > 0)count++;
  }
  return count;  
}

Console.Write("How many numbers do you want to enter?: ");
int m = Convert.ToInt32(Console.ReadLine());

int result = AboveZiro(m);
Console.WriteLine(result);
*/

 // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
 void Point(int b1, int k1, int b2, int k2)
{
 double x = (b1-b2)/(k2-k1);
 double y = (k2*b1-k1*b2)/(k2-k1);
 if(k1==k2)
 {
    Console.Write("Given lines do not intersect");
 } 
 else
 Console.Write($"Point of intersection of two lines: ({x}; {y})");
}

Console.WriteLine("Input a b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Point(b1,k1,b2,k2);
*/