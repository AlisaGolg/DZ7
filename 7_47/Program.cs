/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.Write("Введите кол-во строк: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(); 
Console.Write("Введите кол-во столбцов: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
double[,] matrix = new double[n,m];
 
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-99,100); 
        Console.Write("{0,6:F1}" , matrix[i, j]);
    }
    Console.WriteLine();
}


