// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Write("Задайте длину массива: ");
int leng = Convert.ToInt32(Console.ReadLine());
int [] NewArray(int len)
{
    int [] arrays = new int [len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)  
    {
        arrays[i] = rand.Next(-20,20);
    } 
    return arrays;
}
void PrintArray(int [] arr)
{
    int sum = 0;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    { 
        Console.Write($"{arr[i]},");
        if (i % 2 != 0 && i != 0)
        {
            sum = sum + arr[i];
        }
    }
    Console.Write($"] сумма на нечетных позициях = {sum}");
}

int [] ArraysRes = NewArray(leng);
PrintArray(ArraysRes);

