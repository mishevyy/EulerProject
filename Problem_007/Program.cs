// Задача 7.

// Выписав первые шесть простых чисел, получим 2, 3, 5, 7, 11 и 13. Очевидно, что 6-е простое число - 13.

// Какое число является 10001-м простым числом?

int counter = 0;
int number = 2;
int prime = 0;
while (counter != 10001)
{
    if (IsPrime(number))
    {
        counter++;
        prime = number;
    }
    number++;
}

Console.WriteLine($"10001е простое число равно {prime}");

bool IsPrime(int number)
{
    int counter = 0;
    for (int i = 1; i * i <= number; i++)
    {
        if (number % i == 0)
            counter++;

        if (counter > 1)
            return false;
    }
    return true;
}