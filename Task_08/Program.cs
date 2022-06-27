//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое число: ");
int num=Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= num)
{
    if (index % 2 == 0) 
    {
        Console.Write(index);
    }
    index++;
}