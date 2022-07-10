// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
Console.Write("Задайте длину массива: ");
int leng = Convert.ToInt32(Console.ReadLine());
double [] NewArray(int len)
{
    double [] arrays = new double [len];
     Random rand = new Random();
     for (int i = 0; i < len; i++)  
     {
         arrays[i] = Math.Round((rand.NextDouble()*20),2);
     } 
    return arrays;
}
void PrintArray(double [] arr)
{
    double min = arr[0];
    double max = arr[0];
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    { 
        Console.Write($"{arr[i]}; ");
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    Console.Write($"] разница макс и мин = {max-min}");
}

double [] ArraysRes = NewArray(leng);
PrintArray(ArraysRes);