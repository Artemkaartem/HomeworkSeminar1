// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ввод минимального значения: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    
    Console.Write("Ввод максимального значения: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array= new double[rows, columns];
        for(int i = 0; i< rows;i++)
          for(int j= 0; j < columns; j++)
            array[i,j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);

        return array;
}

void Show2dArray(double[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
         for(int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + " ");

         Console.WriteLine();
      }
      Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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

    int[,] array = new int [rows, columns];
    for(int i = 0; i < rows; i++)
      for(int j = 0; j < columns; j++)
       array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;    
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
     for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
        Console.WriteLine();
    } 
    Console.WriteLine();
}

int Numbers(int[,] array,  int num1, int num2)
{
    int count = 0;
    if(num1 <= array.GetLength(0) && num2 <= array.GetLength(1))
    {
        count = array[num1, num2];
       Console.WriteLine(count);
    }
     else
     {
       Console.WriteLine("числа с такими индексами в массиве нет");
     }
     return count;
}

Console.Write("ВВедите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray();
ShowArray(myArray);

Numbers(myArray,a, b);
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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


double[] Arithmetic(int[,] array)
{
double[] newarray = new double[array.GetLength(1)];

for (int j = 0; j < array.GetLength(1); j++)

    {
    for (int i = 0; i < array.GetLength(0); i++)
        newarray[j] += array[i, j];
        newarray[j]=newarray[j] / array.GetLength(0);
    
    }
return newarray ;

}
void Show(double[] array)
{
      for(int i = 0; i < array.Length; i++)
      {
         Console.Write(Math.Round((array[i]), 2) + " ");
      }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] result = Arithmetic(myArray);
Show(result);


