// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

 
 Console.WriteLine("Введите пятизначное число: ");
 string input=Console.ReadLine();
 int value = Convert.ToInt32(input);
 int a,b,c,d,e;
 int result;

 result = (value/10000);
 a=result;
 result = value%10;
 e=result;
 if (a==e)
 {
    result=(value%10000)/1000;
    b=result;
    result=(value%100)/10;
    d=result;
    if (d==b)
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


