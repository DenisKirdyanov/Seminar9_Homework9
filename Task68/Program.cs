// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Задайте первое неотрицательное число n ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте второе неотрицательное число m ");
int m1 = int.Parse(Console.ReadLine());

static int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return Ack(m - 1, 1);
            }
            else
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
 
        }

Console.WriteLine(Ack(m1, n1));

