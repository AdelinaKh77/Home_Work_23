// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();

int EnterMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


bool ValidNum(int m, int n) => n > 0 && m > 0;

int Sum (int m, int n)
{
    int sum = 0; 

    for(int i = m; i <= n; i++)
    {
        sum += i;
    }

    return sum;
}

int m = EnterMessage("Введите m : ");
int n = EnterMessage("Введите n : ");

if(ValidNum(m, n))
{
    Console.WriteLine($"M = {m} ; N = {n} -> {Sum(m, n)}");
}
else
{
    Console.WriteLine("Ошибка, повторите снова !");
}
