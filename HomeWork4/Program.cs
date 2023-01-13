//Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Degree(int num1, int num2)
{
    int result = 1;
    int b = num2;
    int a = num1;

    for( int count = 1; count <= b; count++ ) 
    {
      result = result * a;
    }
    return result;
}

Console.Write("Input a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int sum = Degree(A,B);
Console.WriteLine(sum); 
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumNumber(int number)
{
  int sum = 0;
  for(int n = -2; n <= number; n++) // -2 потому, что с числами 1902 к примеру результат был на еденицу меньше
  {
    sum = number % 10 + sum;
    number = number / 10;
    
  }
  return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumber(num));
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size]; //выделение памяти для массива
    
    
    for(int i = 0; i < size; i++)
    {
     
     array[i] = Convert.ToInt32(Console.ReadLine());
     
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.Write("]");    
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a numbers for array: ");



int[] newArray = CreateArray(m);
ShowArray(newArray);
*/