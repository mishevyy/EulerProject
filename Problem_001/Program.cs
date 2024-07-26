﻿// Задача 1.

// Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. 
// Сумма этих чисел равна 23.

// Найдите сумму всех чисел меньше 1000, кратных 3 или 5. 


int counter = 0;
int result = 0;

while (counter < 1000)
{
    if (counter % 3 == 0 || counter % 5 == 0)
        result += counter;

    counter++;
}

Console.WriteLine("Сумма всех чисел меньше 1000, кратная 3 или 5: {0}", result);


/*

public void SolveLINQ()
{
    int result = Enumerable.Range(0, 1000)
        .Where(n => n % 5 == 0 || n % 3 == 0)
        .Sum();

    Console.WriteLine("Сумму всех чисел меньше 1000, кратных 3 или 5 равна: {0}", result);
} 
 */