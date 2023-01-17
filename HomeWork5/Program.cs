//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; //выделение памяти для массива

    for(int i = 0; i < size; i++)
    {
     array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.WriteLine();    
}

int NumberOfEvenNumbers(int[] array)
{
    int count = 0;
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = array[i] % 2;
    if(array[i] == 0)
    {
      count++; 
    }
  }
  return count;
}
Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);

int result = NumberOfEvenNumbers(newArray);
Console.WriteLine("Number of even numbers in array is " + result);

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(index).

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; //выделение памяти для массива

    for(int i = 0; i < size; i++)
    {
     array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.WriteLine();    
}

int SumOddElements(int[] array)
{
    int sum = 0;
   for(int i = 0; i < array.Length; i++)
   {   
    int n = 0;
      n = i % 2;

      if(n == 1) 
      {
        sum = sum + array[i];
      }
    }

    return sum;
}
Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);

int result = SumOddElements(newArray);
Console.WriteLine("Sum of add elements is " + result);

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomArray(int size)
{
    int[] arr = new int[size]; //выделение памяти для массива

    
    for(int i = 0; i < size; i++)
    {
     arr[i] = new Random().Next(1, 100);   
    }

    
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
     array[i] = new Random().NextDouble(); 
    }

    double[] array1 = new double[size];
    for(int i = 0; i < size; i++)
    {
        array1[i] = arr[i] + array[i];     
    }
    
    return array1;
}


void ShowArray(double[] array1)
{
    for(int i = 0; i < array1.Length; i++)
    {
      Console.Write(array1[i] + " ");
    }
    Console.WriteLine();    
}

double DiffMinAndMaxElements(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];
   for(int i = 0; i < array.Length; i++)
   {
    while(i < array.Length)
    {
        if(array[i] > max)
        {
          max = array[i];
        }
         if(min > array[i])
         {
            min = array[i];
         }
        i++;
        result = max - min;
    }
   }
   
     return result;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

double[] newArray1 = CreateRandomArray(m);
ShowArray(newArray1);


double result = DiffMinAndMaxElements(newArray1);
Console.WriteLine("Difference between maximum and minimum numbers is " + result);
*/