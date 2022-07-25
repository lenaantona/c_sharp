// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int functionAkkerman (int m, int n)
{
    if (m == 0) return n + 1;
    else
    { 
        if ((m != 0) && (n == 0)) return functionAkkerman(m - 1, 1);
        else return functionAkkerman(m - 1, (functionAkkerman(m, n - 1)));
    }
}
int number = functionAkkerman(3, 2);
Console.Write(number);