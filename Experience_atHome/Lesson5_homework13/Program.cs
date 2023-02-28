// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNum(num);
Console.WriteLine("массив:  ");
PrintArray(num);
int sum = 0;

for (int j =1; j < num.Length; j+=2)
    {
     sum += num [j];
    }
    Console.WriteLine($"сумма элементов на нечётных позициях = {sum} ");

void FillArrayRandomNum(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num [i] = new Random().Next(1,1000);
    }
}
void PrintArray(int[] num) 
{
    System.Console.Write("[");
    for (int i=0; i<num.Length; i ++) 
    {
        System.Console.Write(num [i]+ " ");
    }
    Console.Write("]");
    System.Console.WriteLine();
}