//Задача 52. Задайте двумерный массив из целых чисел.  
//Найдите среднее арифметическое элементов в каждом столбце. 
 
// Например, задан массив: 
//1 4 7 2 
//5 9 2 3 
//8 4 2 4 
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

 double sum1 = 0; double sum2 = 0; 
 double sum3 = 0; double sum4 = 0; 
  
  int [,]array =  
 {   
 {1, 2, 3, 4}, 
 {5, 6, 7, 8}, 
 {9, 10, 11, 12} 
 }; 
 
 sum1 = (array[0,0] + array[1,0] + array[2,0]) / 3; 
 sum2 = (array[0,1] + array[1,1] + array[2,1]) / 3; 
 sum3 = (array[0,2] + array[1,2] + array[2,2]) / 3; 
 sum4 = (array[0,3] + array[1,3] + array[2,3]) / 3; 
Console.WriteLine(sum1); 
Console.WriteLine(sum2); 
Console.WriteLine(sum3); 
Console.WriteLine(sum4);
