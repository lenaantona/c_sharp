// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int [,] CreatMatrixSpiral(int n)
{
    int [,] arr = new int [n, n];
    int i = 0;
    int index = n;
    for (int k = 0; k < n; k++)
    {
        arr[i,k] = k + 1;
    }
    int j = n - 1;
    int r = n;
    int count = 0;
    while (index < n * n)
    {
        r--;
        if (count%2 == 0)
       {
            for (int l = 0; l < r; l++)
            {
                i++;
                index++;
                arr[i,j] = index; 
            }
            for (int l = 0; l < r; l++)
            {
                j--;
                index++;
                arr[i,j] = index;
            }
        }
        else
        {
            for (int l = 0; l < r; l++)
            {
                i--;
                index++;
                arr[i,j] = index; 
            }
            for (int l = 0; l < r; l++)
            {
                j++;
                index++;
                arr[i,j] = index;
            }
        }
        count++;
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
int [,] arrayoriginal = CreatMatrixSpiral(5);
PrintMatrix(arrayoriginal);
