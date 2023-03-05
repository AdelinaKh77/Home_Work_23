// Задача 50. Напишите программу, которая на вход принимает  
//позиции элемента в двумерном массиве, и возвращает значение этого элемента или же  
//указание, что такого элемента нет. 
//Например, задан массив: 
 //1 4 7 2      17 -> такого числа в массиве нет 
 //5 9 2 3 
 //8 4 2 4*/ 
 
int [,]array = 
{ 
{1, 4, 7, 2}, 
 
{5, 9, 2, 3}, 
 
{8, 4, 2, 4} 
}; 
 
System.Console.WriteLine("Введите позицию Y; "); 
int numY = Convert.ToInt32(System.Console.ReadLine()); 
System.Console.WriteLine("Введите позицию X; "); 
int numX = Convert.ToInt32(System.Console.ReadLine()); 
System.Console.WriteLine(); 
 
if (numY>2 || numX > 3) 
{ 
    System.Console.WriteLine("Ошибка"); 
} 
else  
{ 
System.Console.WriteLine(array[numY,numX]); 
}