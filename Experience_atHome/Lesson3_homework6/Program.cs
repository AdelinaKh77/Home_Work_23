// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

 
 Console.WriteLine("Введите пятизначное число: ");
  int value = Convert.ToInt32(Console.ReadLine());
 int a,b,c,d;
 int result;

 result = (value/10000);
 a=result;
 result = value%10;
 d=result;
 if (a==d)
 {
    result=(value%10000)/1000;
    b=result;
    result=(value%100)/10;
    c=result;
    if (c==b)
    {
        Console.WriteLine("Данное число-Полиндром");
    }
    else
    {
        Console.WriteLine("Данное число не является Полиндромом"); 
    }
 }
else
{
    Console.WriteLine("Данное число не является Полиндромом");
}


