// Задача 4.
// Число - палиндром с обеих сторон (справа налево и слева направо) читается одинаково.
// Самое большое число-палиндром, полученное умножением двух двузначных чисел – 9009 = 91 × 99.
// Найдите самый большой палиндром, полученный умножением двух трехзначных чисел.


var polindroms = new List<int>();

for (int a = 1; a <= 999; a++)
    for (int b = 1; b <= 999; b++)
        if (IsPolindrom(a * b))
            polindroms.Add(a * b);

Console.WriteLine("Cамый большой палиндром, полученный умножением двух трехзначных чисел равен {0}", polindroms.Max());


bool IsPolindrom(int number)
{
    string stringNumber = number.ToString();

    if (stringNumber.Length == 1) return true;

    int length = stringNumber.Length;

    // Сравниваем первый и последний, второй и предпоследний и т.д символы
    // до середины строки
    for (int k = 0; k < length / 2; k++)
    {
        if (!stringNumber[k].Equals(stringNumber[length - 1 - k]))
            return false;
    }

    return true;
}