/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
 которая будет находить строку с наименьшей суммой элементов. 
 
Например, задан массив: 
 
 1 4 7 2 
 5 9 2 3 
 8 4 2 4 
 5 2 6 7 
 
Программа считает сумму элементов в каждой строке и выдаёт номер строки  
с наименьшей суммой элементов: 1 строка 
*/

int[,] array =
{ 
    {1,4,7,2}, 
    {5,1,2,3}, 
    {9,4,2,4}, 
    {5,2,6,5} 
}; 
 
int height = array.GetLength(0); 
int width = array.GetLength(1);
int min = int.MaxValue; 
int index = 0; 
 
for (int i = 0; i < height; i++) 
{
    int sum = 0; 
    for (int j = 0; j < width; j++)
    {
        sum += array[i, j];
    } 
    if (sum < min)
    {
        min = sum; 
        index = i;
    } 
 
} 
Console.WriteLine($"Строка под номером: {index}"); 
Console.ReadLine();