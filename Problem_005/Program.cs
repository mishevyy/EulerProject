// Задача 5.

// 2520 - самое маленькое число, которое делится без остатка на все числа от 1 до 10.

// Какое самое маленькое число делится нацело на все числа от 1 до 20?

int next = 2;
for (int i = 1; i < 20; i++)
{
    next = (i * next) / EuclidGCD(i, next);
}

Console.WriteLine($"Самое маленькое число делится нацело на все числа от 1 до 20: {next}");

int EuclidGCD(int a, int b)
{
    while (a != b)
    {
        if (a > b)
            a -= b;
        else
            b -= a;
    }
    return a;
}