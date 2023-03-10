// /* Задача 54: Задайте двумерный массив. Напишите программу,
 //которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
/*1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] array =
{
    {1,4,7,2 },
    {2,9,5,3 },
    {8,4,2,4 }
};

        int height = array.GetLength(0);
        int width = array.GetLength(1);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width-1; j++)
            {
                for (int z = j+1; z < width; z++)
                {
                    if (array[i, j] > array[i, z])
                    {
                    int box = array[i, j];
                    array[i, j] = array[i, z];
                    array[i, z] = box;
                    }
                }    
            }
        }
    for (int i = 0; i < height ; i++)
    {
        int n = width ;
        for (int j = 0; j < n /2; j++)
        {
        int box = array[i,j];
        array[i,j] = array[i, n - j - 1];
        array[i,n - j - 1] = box ;
        }
    }
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
       System.Console.Write($"{ array[i,j]} \t"); 
    }
}