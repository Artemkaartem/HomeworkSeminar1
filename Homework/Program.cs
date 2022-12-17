//  Домашнее задание. Семинар 1.

//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Imput a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2)
{
    Console.WriteLine(num1 + " меньше " + num2 + " больше");
}
else
{
    Console.WriteLine(num1 + " больше " + num2 + " меньше");
}
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Imput a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num1>max) max = num1;
if(num2>max) max = num2;
if(num3>max) max = num3;
Console.WriteLine(max);
*/




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Imput a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
      Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
*/




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Imput a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= num)
{
    if(current % 2 == 0)
    Console.Write(current + " ");
    current = current + 1;
}
*/
