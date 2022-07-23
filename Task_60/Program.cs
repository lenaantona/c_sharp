// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int [,,] CreatThreeMatrixRndInt(int m, int n, int k, int min, int max)
{
    int [,,] arr = new int [m, n, k];
    Random rnd = new Random();
    int [] noarr = new int [m * n * k];
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int r = 0; r < arr.GetLength(2); r++)
            {  
                int res = rnd.Next(min, max);
                while (Array.Exists(noarr, element => element == res))
                {
                    res = rnd.Next(min, max);
                }
                noarr [index] = res;
                arr[i,j,r] = res;
                index++;
            }
        }
    }
    return arr;
}
void PrintMatrix(int [,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           for (int r = 0; r < arr.GetLength(2); r++)
           {
            Console.Write($"{arr[j,r,i],4}({j},{r},{i}) ");
           }
           Console.WriteLine();
        }
        
    }
}
int [,,] arrayresult = CreatThreeMatrixRndInt(2, 2, 2, 1, 20);
PrintMatrix(arrayresult);