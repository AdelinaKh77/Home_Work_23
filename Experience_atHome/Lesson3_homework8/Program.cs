// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int [] array={3,6,8,2,1,-7};
int  sum1=(array [3]-array[0])*(array [3]-array[0]);
int  sum2=(array [4]-array [1])*(array [4]-array [1]);
int  sum3= (array [5]-array[2])*(array [5]-array[2]);
double sum=sum1+sum2+sum3;
double result = Math.Sqrt(sum);
Console.WriteLine(result);