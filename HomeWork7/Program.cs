//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray()
{
   Console.Write("Input a number of rows: ");
 int rows = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a number of columns: ");
 int columns = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min possible value: ");
 int minValue = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max possible value: ");
 int maxValue = Convert.ToInt32(Console.ReadLine());
 
 double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j ++)
        {
            array[i,j] =  new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ArrayIndex(int[,] array)
{
    Console.Write("Input a index rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a index columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = -1;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (m > array.GetLength(0) || n > array.GetLength(1))
            {
              Console.Write("No numbers with such index ");
            }
            else result = array[i, j];
        }
    }



    return result;
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int Result = ArrayIndex(myArray);
Console.Write(Result);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArithmeticMeanOfNumbers(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)} ");
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

ArithmeticMeanOfNumbers(myArray);
*/