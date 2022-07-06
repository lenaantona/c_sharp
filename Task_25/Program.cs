// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите целое число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int Pow (int a1, int b1)
{
    int result = 1;
    for (int i = 0; i < b1; i++)
    {
        result = result * a1;
    }
    return result;
}
int powres = Pow(a, b);
Console.Write($"{a} в степени {b} = {powres}");