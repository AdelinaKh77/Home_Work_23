// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

System.Console.WriteLine("Укажите размер массива: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[number]; 
 
for(int i = 0; i < array.Length; i++) 
{ 
    System.Console.Write($"Укажите вещественное число индексу {i}: "); 
    array[i] = Convert.ToInt32(System.Console.ReadLine()); 
    System.Console.WriteLine(array[i]); 
} 
int max = array[0]; 
int min =array[0]; 
 
for(int i = 1; i < number; i++) 
{ 
   if(array[i] > max) max = array[i]; 
   if(array[i] < min) min = array[i]; 
} 
System.Console.Write($"Разность Max и Min равна: {(max-min)}");