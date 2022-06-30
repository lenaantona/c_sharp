//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int rndNum = new Random().Next(100,1000);
Console.WriteLine(rndNum);
int NewNum(int num)
{
    int num1 = num % 100;
    int num2 = num % 10;
    return num = num1 - num2;
}
int result = NewNum(rndNum) / 10;
Console.WriteLine(result);
