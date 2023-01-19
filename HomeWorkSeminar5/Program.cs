// Домашнее задание. Семинар 5.

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
  {
    int[] array = new int[size];
    {
            for (int i = 0; i < size; i++)            
                array[i] = new Random().Next(100, 1000);
    }
    return array;
  } 


void ShowArray(int[] array)
{
    for(int i = 0; i <array.Length;i++)
    Console.Write(array[i] + " ");
   Console.WriteLine();
}

int Numbers(int[] array )
{
    int count = 0;
    for(int i = 0; i <array.Length;i++)
    {
       if(array[i] % 2 == 0)
       count++;
    }
    return count;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);

int result = Numbers(newArray);
Console.WriteLine(result);
*/



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*

int [] CreateRandomArray (int size, int minValue, int maxValue)
  {
    int[] array = new int[size];
    {
            for (int i = 0; i < size; i++)            
                array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
  } 


void ShowArray(int[] array)
{
    for(int i = 0; i <array.Length;i++)
    Console.Write(array[i] + " ");
   Console.WriteLine();
}

int Numbers(int[] array )
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
      if(i % 2 != 0)
      
       count += array[i];
    }
    return count;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);

int result = Numbers(newArray);
Console.WriteLine(result);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double [] CreateRandomArray (int size, int minValue, int maxValue)
  {
    double[] array = new double[size];
    {
        for (int i = 0; i < size; i++)  

        array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2); 

         //array[i] = new Random().Next(minValue, maxValue ) + new Random().NextDouble();
    }
    return array;
  } 

void ShowArray(double[] array)
{
    for(int i = 0; i <array.Length;i++)
    Console.Write(array[i] + " ");
   Console.WriteLine();
}

double [] Numbers(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max )
        {
       max = array[i];
        }
        if (array[i] < min)
        {
        min = array[i];
        }
    }
    Console.WriteLine(max -min);
   return array ;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);

double[] result = Numbers(newArray);

Console.WriteLine(result);
