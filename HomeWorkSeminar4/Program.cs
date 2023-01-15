// Домашнее задание. Семинар 4.

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Numbers(int a, int b)
{
   int count = 1;
   for(int i = 1; i <= b; i++)
     count = count * a;
   return count; 
}

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Numbers(a, b);
Console.WriteLine(result);
*/



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Numbers(int n)
{
    int sum = 0;
    while(n > 0)
    {
        sum = sum + n % 10;
            n = n / 10;
    }
    return sum;

}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = Numbers(a);
Console.WriteLine(result);
*/




// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

              
  int [] CreateArray (int i)
  {
    int[] myArray = new int[i];
    {
            for (int a = 0; a < i; a++)
            {
                Console.WriteLine("Введите элемент массива");
                myArray[a] = Convert.ToInt32(Console.ReadLine());

            }
    }
    return myArray;
  } 


void ShowArray(int[] array)
{
    for(int i = 0; i <array.Length;i++)
    Console.Write(array[i] + " ");
   Console.WriteLine();
}


Console.Write("Введите количество элементов массива: ");
int b = Convert.ToInt32(Console.ReadLine());



int[] newArray = CreateArray(b);
ShowArray(newArray);