// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:1 строка
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

int [] SumStringMatrix (int [,] arr)
{
    int [] arrayRes = new int [arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr [i, j];
        }
        arrayRes[i] = sum;
    }
    return arrayRes; 
}
int MinSumArray (int [] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) 
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}

int [,] arrayoriginal = CreatMatrixRndInt(4, 4, 1, 20);
PrintMatrix(arrayoriginal);
int [] ArraySumString = SumStringMatrix(arrayoriginal);
Console.WriteLine();
int minsum = MinSumArray(ArraySumString)+1;
Console.WriteLine($"Строка с минимальной суммой элементов {minsum}");