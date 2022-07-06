// Задача 29: Напишите программу, которая задаёт массив из 8 элементов,
// заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Write("До какого случайного максимального числа будет заполняться массив: ");
int nummax = Convert.ToInt32(Console.ReadLine());
int [] NewArray(int max)
{
    int [] arrays = new int [8];
    Random rand = new Random();
    for (int i = 0; i < 8; i++)  
    {
        arrays[i] = rand.Next(1,max+1);
    } 
    return arrays;
}
void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    { 
        if (i == 7)
        {
            Console.Write($"{arr[i]}");
        }
        else 
        {
            Console.Write($"{arr[i]}, ");
        }
    }
    Console.Write("]");
}
PrintArray(NewArray(nummax));


