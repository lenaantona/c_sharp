// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int [,] CreatMatrixRndInt(int m, int n, int min, int max)
{
    int [,] arr = new int [m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(min, max);
        }
    }
    return arr;
}

void PrintMatrix(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if (j == 0) Console.Write("|"+$"{arr[i,j],2}"+"|");
           else Console.Write($"{arr[i,j],2}"+"|");
        }
        Console.WriteLine();
    }
}

int [,] SortStringMatrix (int [,] arr)
{
  int []  arrayRes = new int [arr.GetLength(1)];  
  for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrayRes[j] = arr [i,j];
        }
        Array.Sort(arrayRes);
        Array.Reverse(arrayRes);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = arrayRes [j];
        }
    } 
    return arr;   
}


int [,] arrayoriginal = CreatMatrixRndInt(4, 4, 1, 20);
PrintMatrix(arrayoriginal);
int [,] arrayResult = SortStringMatrix(arrayoriginal);
Console.WriteLine();
PrintMatrix(arrayResult);