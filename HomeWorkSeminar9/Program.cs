//Домашнее задание. Семинар 9.

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью
/*
void Show(int num)
{
    Console.Write(num + " ");
    if(num >1) Show(num - 1);
}
Show(5);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNatNum(int M, int N)
{
    if (N > M) return M + SumNatNum(M + 1,N);
    else if (M == N) return N ;
    else return 0;
}

int result = SumNatNum(1, 15);
Console.WriteLine(result);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

int result = Akkerman(3, 2);
Console.WriteLine(result);
*/