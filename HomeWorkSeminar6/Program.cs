//  Домашнее задание. Семинар 6.

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int Print(int num)
{
    int count = 0;
     for (int i = 0; i < num; i++)
    {
        Console.Write("Введите число: ");
      int v = Convert.ToInt32(Console.ReadLine());
        if (v > 0)
        {
           count++;
        }
    }
    return count;
}


Console.Write("Всего чисел ");
int m = Convert.ToInt32(Console.ReadLine());


int result = Print(m);
Console.Write($"Больше 0 введено: {result}");
  */




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
double x = 0;
double y = 0;
x = (b2 - b1)/(k1 - k2);

y=k1*x+b1;
Console.WriteLine($"Пересечение в точке: ({x};{y})");




