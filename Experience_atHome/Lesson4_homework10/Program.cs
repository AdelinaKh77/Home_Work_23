// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int count = Convert.ToString(numberN).Length;
    int a = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      a = numberN - numberN % 10;
      result = result + (numberN - a);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
