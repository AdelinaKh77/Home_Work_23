﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

int N = 10;
int num = 2;

while (num <= N)
{
   if (num % 2 == 0)
   {  
   Console.WriteLine(num + " ");
    num++;
   }
   else 
   {
    num++;
   }
} 