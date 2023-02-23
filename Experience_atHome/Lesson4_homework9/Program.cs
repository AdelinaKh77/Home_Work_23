// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Math.Pow использовать нельзя
//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine( "Введите  число:  ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите степень: ");
int power = Convert.ToInt32(Console.ReadLine());

int result = value;
for (int i = 1; i<power; i++)
{
value = result*value;
}
Console.WriteLine(value);




