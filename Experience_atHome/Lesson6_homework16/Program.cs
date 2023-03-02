// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


System.Console.Write("Введите значение (b1); ");

double numA = double.Parse(Console.ReadLine());

System.Console.Write("Введите значение (k1); ");

double numB = double.Parse(Console.ReadLine());

System.Console.Write("Введите значение (b2); ");

double numC = double.Parse(Console.ReadLine());

System.Console.Write("Введите значение (k2); ");

double numD = double.Parse(Console.ReadLine());

double dotX ;

double res = numB - numD;

if ( res < 0) 

{
    res = res * (-1);

    dotX = (numC - numA) / res;

    dotX =  dotX * (-1);
}
else
{
 dotX = (numC - numA) / res;   
}
double dotY = numB * dotX + numA;

System.Console.WriteLine($"Координаты пересечения двух прямых: {dotY} , {dotX}");
