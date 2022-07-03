//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = num.ToString().Length;
int i = 0;
if (num > 99)
{
   int [] arrays = new int[len];
   while (num > 0)
   {
      arrays[i] =  num % 10;
      num = num / 10;
      i++;
   }
   Console.Write(arrays[len-3]);
}
else 
{
   Console.WriteLine("Третьей цифры нет");
}
