//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое целое число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int num3=Convert.ToInt32(Console.ReadLine());
int max;
if (num1>num2)
{
    max=num1;
}
else {if (num2>num3)
{max=num2};
else {max=num3}};
Console.WriteLine($"Максимальное число{max}");
