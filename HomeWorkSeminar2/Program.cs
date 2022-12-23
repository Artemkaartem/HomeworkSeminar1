// Домашнее задание. Семинар 2.

// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int numbe(int num)
{
    int sot = num / 10 % 10;
    return sot;
}

Console.WriteLine("Введите трехзначное число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 >=100 & num1< 1000 )
{
    int newNumber = numbe (num1);
    Console.WriteLine(newNumber); 
}
else if (num1 <=-100 & num1> -1000 )
{
    int newNumber = num1 / 10 % 10 * -1;
    Console.WriteLine(newNumber);
}
else 
{
   Console.WriteLine("Попробуйте еще раз");
}
*/



// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

int number (int num ,int str)
{
      int result = 0;
    if (str < 3)
    {
       Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int c = 1;
        int a = str;
        while(a > 3 )
        {
         c =c * 10;
         a = a - 1;
        }
        result = num / c % 10;
    } 
       

    return result;
}


Console.WriteLine("Введите трехзначное число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());


int count = num1.ToString().Length;
Console.Write(number(num1, count));
*/



// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool nedel (int num1)
{
 if (num1 == 6 || num1 == 7  )
 
 {
    return true;
 }
else
 {
    return false;
 }
}


Console.WriteLine("Введите число недели:  ");
int num = Convert.ToInt32(Console.ReadLine());

bool tf = nedel(num);



if (nedel(num))

{
    Console.WriteLine(" Является выходным днем ");
}
 else if( num>= 1 &&  num<=5)
 {
    Console.WriteLine(" Не является выходным днем ");

 }

if (num > 7 || num < 1 )
 {
       Console.WriteLine("Попробуйте еще раз");
 }
    
*/