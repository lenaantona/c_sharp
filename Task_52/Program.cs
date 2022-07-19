// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double [] AverageColumn (int [,] arr)
{
    double []  arrayRes = new double [arr.GetLength(1)];
   
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr [j, i];
        }
        arrayRes[i] = Math.Round(sum / arr.GetLength(0),2);
    }
    return arrayRes; 
}

void PrintArray(double [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    { 
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
        }
        else 
        {
            Console.Write($"{arr[i]}; ");
        }
    }
    Console.Write("]");
}

int [,] arrayoriginal = CreatMatrixRndInt(3, 4, 1, 20);
PrintMatrix(arrayoriginal);
double [] arrayResult = AverageColumn(arrayoriginal);
Console.WriteLine();
PrintArray(arrayResult);