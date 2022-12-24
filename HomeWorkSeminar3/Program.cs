// Домашнее задание. Семинар 3

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int Number(int num)
{
    int result = 0;
    while(num > 0)
    {
        result = result * 10 + num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == Number(n)) Console.WriteLine("Является палиндром");
else Console.WriteLine("Не является палиндром");
*/





// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distanse(double x1, double y1, double z1, 
             double x2, double y2, double z2)
{
        double res1 = Math.Pow(x2 - x1, 2);
        double res2 = Math.Pow(y2 - y1, 2);
        double res3 = Math.Pow(z2 - z1, 2);
        double result = Math.Sqrt(res1 + res2 + res3 );
        return result;
}


Console.WriteLine("Введите координаты первой точки:  ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки:  ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки:  ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второй точки:  ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второй точки:  ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второй точки:  ");
double z2= Convert.ToDouble(Console.ReadLine());



Console.WriteLine("Расстояние между точками "  + Distanse (x1,y1, z1, x2,y2, z2));
*/



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Kub(int n)
{
    Console.WriteLine("Кубы чисел: ");
    int count = 1;
    while(count < n+1)
    {
        Console.Write(count * count * count + " ");
        count = count +1;
    }
}

Console.WriteLine("Введите число n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Kub(n);
*/