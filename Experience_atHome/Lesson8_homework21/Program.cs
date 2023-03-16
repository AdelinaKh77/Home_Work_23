//Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.



Console.Clear();

int EnterMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool ValidNum(int num) => num > 0;

string ReturnNumber(int Num)
{
    if (Num >= 1)
    {
        return $"{Num} " + ReturnNumber(Num - 1);
    }
    else
    {
        return String.Empty;
    }
}

int num = EnterMessage("Введите число : ");

if (ValidNum(num))
{
    Console.WriteLine(ReturnNumber(num));
}
else
{
    Console.WriteLine("Ошибка, попробуйте снова !");
}