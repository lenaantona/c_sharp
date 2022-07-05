// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите целое пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = num.ToString().Length;
int i = 0;
if (len == 5)
{
   int [] arrays = new int[len];
   while (num > 0)
   {
      arrays[i] =  num % 10;
      num = num / 10;
      i++;
   }
  
  if (arrays[0] == arrays[4] && arrays[1] == arrays[3])
   {
    Console.Write("да");
   }
   else
   {
     Console.Write("нет");    
   }
}
else
{
    Console.Write("Ошибка");
}