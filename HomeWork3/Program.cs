// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int Number(int numb)
{
    
    int des = numb / 10;
    int ed = numb % 10;
    int result = des * 10 + ed;

    if (result == numb) return result;
    else
    {
        int res = -1;
        Console.WriteLine("Number is not palindrome"); 
        return res;
    }    
    
      
}

Console.Write("Input a number: ");
int palindrom = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Number(palindrom));
*/
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double GetDistance (double x1,double y1, double z1, 
                 double x2, double y2, double z2)
{
double res1 = Math.Pow(x2 - x1, 2);
double res2 = Math.Pow(y2 - y1, 2);
double res3 = Math.Pow (z2 - z1, 2);
double result = Math.Sqrt(res1 + res2 + res3);
return result;
}

Console.Write("Input coordinates a first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates a second point: ");
double x2 = Convert.ToDouble(Console.ReadLine()); 
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Distance between points: " + GetDistance(x1, y1, z1, x2, y2, z2));
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void GetCube(int n)
{   
    int sum = 0;
    int count = 1;
    while(count <= n)
    {
     sum = count * count * count;
     Console.WriteLine(sum);
     count++;
    }
} 

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

GetCube(n);
*/

int Number(int numb)
{
    
    int x = numb / 10;
    int y = numb % 10;
    int q = x / 10;
    
    int result = y * 10 + q;

    if (result == numb) return result;
    else
    {
        int res = -1;
        Console.WriteLine("Number is not palindrome"); 
        return res;
    }    
    
      
}

Console.Write("Input a number: ");
int palindrom = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Number(palindrom));
