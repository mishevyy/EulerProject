// Задача 10.
// Сумма простых чисел меньше 10 равна 2 + 3 + 5 + 7 = 17.
// Найдите сумму всех простых чисел меньше двух миллионов.

int constrain = 2_000_000;
long primeSum = 0;

for (int number = 2; number <= constrain; number++)
{
    if (IsPrime(number))
        primeSum += number;
}

Console.WriteLine($"Сумма всех простых чисел меньше двух миллионов: {primeSum}");

bool IsPrime(int number)
{
    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}
