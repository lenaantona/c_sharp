﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 && num < 8)
{
  if (num == 6 || num == 7) 
  {
    Console.Write("Да");
  }
  else 
  {
    Console.Write("Нет");
  }
}
else Console.Write("Ошибка");