// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ввод минимального значения: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    
    Console.Write("Ввод максимального значения: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array= new int[rows, columns];
        for(int i = 0; i< rows;i++)
          for(int j= 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
         for(int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + " ");

         Console.WriteLine();
      }
      Console.WriteLine();
}

void Sorted(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1) - 1; j++) 
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

Sorted(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ввод минимального значения: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    
    Console.Write("Ввод максимального значения: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array= new int[rows, columns];
        for(int i = 0; i< rows;i++)
          for(int j= 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
         for(int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + " ");

         Console.WriteLine();
      }
      Console.WriteLine();
}

void Number(int[,] matrix)
{
    int minSumIndex = 0;
    int minSum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentSum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentSum += matrix[i, j];
        }

        if (i == 0) minSum = currentSum;
        else if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumIndex = i;
        }
    }
Console.Write($"Строка с минимальной суммой элементов равна {minSumIndex + 1 }. ");    
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Number(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
{
    const int rows = 2;
    const int columns = 2;
    const int minValue = 1;
    const int maxValue = 10;
    const int rows2 = 2;
    const int columns2 = 2;
    const int minValue2 = 1;
    const int maxValue2 = 10;

int rows3= 0;
  int columns3 = 0;
    int[,] massiv = new int[rows3, columns3];

    int[,] array= new int[rows, columns];
    int[,] newarray= new int[rows2, columns2];
        for(int i = 0; i< rows ; i++)
        {
          for(int j = 0; j < columns; j++)
          {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
            newarray[i,j] = new Random().Next(minValue2, maxValue2 + 1);
          }
        }
        return array;
}

void Show(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
        Console.Write("|");
         for(int j = 0; j < array.GetLength(1); j++)

         Console.Write(array[i, j] + " ");      

        Console.WriteLine("|");
      }
      Console.WriteLine();
}

void Proizved(int[,] array, int[,] newarray,int[,] massiv )
{
    for(int i = 0; i < newarray.GetLength(0) ; i++)
      {
          for(int j = 0; j < newarray.GetLength(1) ; j++)
      {
          int sum = 0;

            for (int k = 0; k < massiv.GetLength(1); k++)
          {
          sum += array[i,k] * newarray[k,j];
          }
          massiv[i,j] = sum;
      }
      } 
}

int[,] myArray = CreateRandom2dArray();
int[,] array2 = CreateRandom2dArray();
Console.WriteLine("Первая матрица: ");
Show(myArray);
Console.WriteLine("Вторая матрица: ");
Show(array2);

int[,] massiv = CreateRandom2dArray();
Proizved(myArray,array2, massiv);
Console.WriteLine("Произведение: ");
Show(massiv);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray()
{
    const int rows = 2;
    const int columns = 2;
    const int depth = 2;

    int[,,] array= new int[rows, columns,depth];
    
        for(int i = 0; i< rows;i++)
        {
          for(int j= 0; j < columns; j++)
          {
             for(int k= 0; k < depth; k++)
             {
            array[i, j, k] = new Random().Next(10, 99);
             }
          }
        }
        return array;
}

void Show3dArray(int[,,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
         for(int j = 0; j < array.GetLength(1); j++)
         for(int k= 0; k < array.GetLength(2); k++)
         Console.Write(array[i, j, k] + " ");

         Console.WriteLine();
      }
      Console.WriteLine();
}

void Index(int[,,] array)
{

  for (int i = 0; i < array.GetLength(0); i++)
  
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.WriteLine();
      for (int k = 0; k < array.GetLength(2); k++)
      
       Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
    }
}  


int[,,] myArray = CreateRandom3dArray();
Show3dArray(myArray);
Index(myArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateRandom2dArray()
{
    const int rows = 4;
    const int columns = 4;

    int[,] array= new int[rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;
 
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {

        array[i, j] = temp;
        temp++;
  
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
  
        else if (i < j && i + j >= array.GetLength(0) - 1)
         i++;

        else if (i >= j && i + j > array.GetLength(1) - 1)
         j--;

        else
        i--;
     }

  return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
         for(int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + " ");

         Console.WriteLine();
      }
      Console.WriteLine();
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
