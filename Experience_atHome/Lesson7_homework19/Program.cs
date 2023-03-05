//Задача №47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами. 
//m = 3, n = 4.*/ 
 
double [,] array = new double [,] 
{ 
{0.5, 4.6, 7.2, 2.3}, 
 
{1.2, 3.3, 3.8, 1.5}, 
 
{8.4, 7.7, 8.7, 1.5}}; 
 
int height = array.GetLength(0); 
int width = array.GetLength(1); 
 
for(int i = 0; i < height; i ++) 
{ 
  for(int j = 0; j < width; j++) 
  { 
     Console.Write("{0,6:F2}",array[i, j]); 
  } 
  System.Console.WriteLine(); 
}