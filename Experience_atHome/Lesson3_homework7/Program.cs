// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125



Console.WriteLine("Введите любое целое число");
string input = Console.ReadLine();
int N = Convert.ToInt32(input);

int a = 1;
int result;
while (a <= N)
    {
     result = a*a*a;
     Console.WriteLine(result);
     a++;
    }

   Console.WriteLine("вычисление окончено");

    

