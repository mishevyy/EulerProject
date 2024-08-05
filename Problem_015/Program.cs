// Задача 15.
// Начиная в левом верхнем углу сетки 2×2 и имея возможность двигаться только вниз или вправо, существует ровно 6 маршрутов до правого нижнего угла сетки.
// Сколько существует таких маршрутов в сетке 20×20?

int countSide = 20;
int len = countSide + 1;
long[,] array = new long[len, len];

for (int k = 0; k < len; k++)
    array[0, k] = 1;
for (int k = 0; k < len; k++)
    array[k, 0] = 1;

for (int i = 1; i < len; i++)
{
    for (int j = 1; j < len; j++)
    {
        array[i, j] = array[i, j - 1] + array[i - 1, j];
    }
}

for (int i = 0; i < len; i++)
{
    for (int j = 0; j < len; j++)
        Console.Write(array[i, j] + "\t");

    Console.WriteLine();
}

Console.WriteLine($"Количество маршрутов в сетке 20×20: {array[len - 1, len - 1]}");