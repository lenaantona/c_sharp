// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
           if (j == 0) Console.Write("|"+$"{arr[i,j],3}"+"|");
           else Console.Write($"{arr[i,j],3}"+"|");
        }
        Console.WriteLine();
    }
}

int [,] MultiplicationMatrix(int [,] arr1, int [,] arr2)
{
    int [,] arr = new int [arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int sum = 0;
            for (int r = 0; r < arr1.GetLength(1); r++)
            {
                sum = sum + arr1[i,r] * arr2[r,j];
            }
            arr[i,j] = sum;
        }
    }
    return arr;
}

int [,] array1 = CreatMatrixRndInt(2, 3, 1, 10);
PrintMatrix(array1);
Console.WriteLine();
int [,] array2 = CreatMatrixRndInt(3, 2, 1, 10);
PrintMatrix(array2);
int [,] arrayresult = MultiplicationMatrix(array1, array2);
Console.WriteLine();
PrintMatrix(arrayresult);
