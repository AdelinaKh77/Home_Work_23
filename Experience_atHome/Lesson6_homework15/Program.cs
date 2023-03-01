// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3/

System.Console.Write("Какое количество чисел будет проверяться: "); 
 int number= int.Parse(Console.ReadLine()); 
int[] array = new int[number]; 
 
for (int i = 0; i < array.Length; i++) 
{ 
System.Console.WriteLine($"Заполните ячейки числами {i}: "); 
array[i]= int.Parse(System.Console.ReadLine());  
} 
int sum = 0; 
for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] > 0) sum += 1; 
    } 
System.Console.WriteLine($"В массиве {sum} числа больше нуля.");