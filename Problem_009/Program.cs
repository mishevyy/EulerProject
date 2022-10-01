// Задача 9.

// Тройка Пифагора - три натуральных числа a < b < c, для которых выполняется равенство

// a^2 + b^2 = c^2
// Например, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

// Существует только одна тройка Пифагора, для которой a + b + c = 1000.
// Найдите произведение abc.

Foo();

void Foo()
{
    bool isComing = false;
    while (!isComing)
    {
        for (int z = 5; z < 500; z++)
        {
            if (isComing) break;
            for (int y = 4; y < z; y++)
            {
                if (isComing) break;
                for (int x = 3; x < y; x++)
                {
                    if (x * x + y * y == z * z)
                    {
                        if (x + y + z == 10000)
                        {
                            Console.WriteLine($"произведение abc: {x * y * z}");
                            isComing = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}