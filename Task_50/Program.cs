// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
Console.Write("Задайте № строки массива (нумерация с 0): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте № столбца массива (нумерация с 0): ");
int n = Convert.ToInt32(Console.ReadLine());
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
void SearchMatrix (int [,] arr, int m1, int n1)
{
    if (m1 < arr.GetLength(0) && n1 < arr.GetLength(1))
    {
        Console.Write(arr[m1, n1]);
    }
    else Console.Write("такого числа в массиве нет");
}

int [,] arrayResult = CreatMatrixRndInt(4, 4, 1, 20);
PrintMatrix(arrayResult);
SearchMatrix(arrayResult, m, n);
