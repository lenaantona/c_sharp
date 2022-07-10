// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Write("Задайте длину массива: ");
int leng = Convert.ToInt32(Console.ReadLine());
int [] NewArray(int len)
{
    int [] arrays = new int [len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)  
    {
        arrays[i] = rand.Next(100,1000);
    } 
    return arrays;
}
void PrintArray(int[] arr)
{
    int col = 0;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    { 
        Console.Write($"{arr[i]},");
        if (arr[i] % 2 == 0) col++;
    }
    Console.Write($"] кол-во четных чисел = {col}");
}
int [] ArraysRes = NewArray(leng);
PrintArray(ArraysRes);
