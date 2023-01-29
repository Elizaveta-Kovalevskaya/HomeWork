//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void Order(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }                            
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Order(myArray);
Show2dArray(myArray);

*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] CreateRandom2dArray()
{

    int rows = 6;
    int columns = 4;
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

void SumMinimalsRows(int[,] array)
{
    int minimalRow = 0;
    int sumMinimalRow = 0;
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minimalRow += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minimalRow)
        {
            minimalRow = sumRow;
            sumMinimalRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{sumMinimalRow + 1} row");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

SumMinimalsRows(myArray);

*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] Array3D ()
{
 Console.WriteLine($"Input a size array x * y * z: ");
 Console.Write("Input a x: ");
 int x = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a y: ");
 int y = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a z: ");
 int z = Convert.ToInt32(Console.ReadLine());

 int[,,] array3D = new int[x, y, z];

 

 int[] sum = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < sum.GetLength(0); i++)
  {
    sum[i] = new Random().Next(10, 100);
    number = sum[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (sum[i] == sum[j])
        {
          sum[i] = new Random().Next(10, 100);
          j = 0;
          number = sum[i];
        }
          number = sum[i];
      }
    }
  }
  int count = 0; 
  for (int x1 = 0; x1 < array3D.GetLength(0); x1++)
  {
    for (int y1 = 0; y1 < array3D.GetLength(1); y1++)
    {
      for (int z1 = 0; z1 < array3D.GetLength(2); z1++)
      {
        array3D[x1, y1, z1] = sum[count];
        count++;
      }
    }
  }
  return array3D;
}




void ShowArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write(array3D[i,j,k]);
        Console.Write((i,j,k));
        Console.Write($" ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}


int[,,] array = Array3D();
ShowArray(array);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,] CreateRandom2dArray()
{
    int rows = 4;
    int columns = 4;
    


    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1,15);
        }
    }
    return array;
}

int[,] Spiral (int[,] array)
{
  
  int temp = 1;
  int i = 0;
  int j = 0;

  while (temp <= array.GetLength(0) * array.GetLength(1))
  {
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
    else if (i < j && i + j >= array.GetLength(0) - 1) i++;
    else if (i >= j && i + j > array.GetLength(1) - 1) j--;
    else i--;
  }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Spiral(CreateRandom2dArray());
ShowArray(Spiral(CreateRandom2dArray()));
*/
