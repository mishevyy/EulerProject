﻿// Задача 2.

// Каждый следующий элемент ряда Фибоначчи получается при сложении двух предыдущих. 
// Начиная с 1 и 2, первые 10 элементов будут:
// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

// Найдите сумму всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона.  



int a = 0;
int b = 1;
int result = 0;

while (b < 4_000_000)
{
    if (b % 2 == 0)
        result += b;

    b = b + a;
    a = b - a;
}

Console.WriteLine("Сумма всех четных элементов ряда Фибоначчи, меньше 4_000_000: {0}", result);