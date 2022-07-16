// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Write("Колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] NewArray(int len)
{
    int [] arrays = new int [len];
    for (int i = 0; i < len; i++)  
    {
        Console.Write("Введите число: ");
        arrays[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return arrays;
}
int CountNumber (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       
        if (arr[i] > 0) 
        {
            count++;
        }
    }
    return count;
}

int [] ArraysRes = NewArray(M);
int result = CountNumber(ArraysRes);
Console.Write($"Кол-во чисел больше 0 = {result}");