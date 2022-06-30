//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;
if (num>99)
{
   while (index<2)
   {
    num = (num - num % 10) / 10;
    index++;
   }
   Console.WriteLine(num);
}
else Console.WriteLine("Третьей цифры нет");
