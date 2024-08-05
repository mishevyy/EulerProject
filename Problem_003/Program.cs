// Задача 3.
// Простые делители числа 13195 - это 5, 7, 13 и 29.
// Каков самый большой делитель числа 600851475143, являющийся простым числом? 

long bigNumber = 600_851_475_143;

for (long divider = 2; divider < bigNumber; divider++)
    if (bigNumber % divider == 0)
    {
        long tesPrime = bigNumber / divider;
        if (IsPrime(tesPrime))
        {
            Console.WriteLine("Найбольший делитель числа {0}, являющийся простым числом равен {1}", bigNumber, tesPrime);
            break;
        }
    }


bool IsPrime(long number)
{
    if (number == 1) return false;
    long condition = number < 11 ? number : number / 2;

    int divider = 2;

    while (divider < condition)
    {
        if (number % divider == 0)
            return false;

        divider++;
    }

    return true;
}




void MaxPrimeDivider(long number)
{
    int divider = 1;
    long condition = number;
    while (divider <= condition)
    {
        divider++;

        if (condition % divider == 0)
        {
            condition /= divider;
        }
    }

    Console.WriteLine("Найбольший делитель числа {0}, являющийся простым числом равен {1}", number, divider);
}
