// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8-> 30
Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void SumNumber(int mnum, int nnum, int sum)
{
    if (mnum == nnum) Console.Write(sum + nnum);
    if (mnum < nnum)
    {
        sum = sum + mnum;
        SumNumber(mnum + 1, nnum, sum);
    }
    if (mnum > nnum)
    {
        sum = sum + mnum;
        SumNumber(mnum - 1, nnum, sum);
    }
}
SumNumber(m, n, 0);