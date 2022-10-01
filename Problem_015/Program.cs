// Задача 15.

// Начиная в левом верхнем углу сетки 2×2 и имея возможность двигаться только вниз или вправо, существует ровно 6 маршрутов до правого нижнего угла сетки.

// Сколько существует таких маршрутов в сетке 20×20?

int countSide = 20; // 
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



//long f = Step(0, 0, 4); // 137846528820
//Console.WriteLine(f);

////StepTest(0,0, 2);

//long Step(int i, int j, int count)
//{
//    long a = 0;
//    if (i == 
//     == count) { r
//     (i != count && j != co


//        int t

//        a += S
// j, count);

//        int y = j + 1;

//a
//    , y, count);

//     else if (i != count &&
//c

//    {
//        int t = i + 1;

//a
//    , j, count);

//     else if (i == count &&
//c

//    {
//        int t = j + 1;
//        a += Step(i, t, count);
//    }
//    return a;
//}

//void StepTest(int i, int j, int c ount)
//{
//    if (i == count && j == count) { Console.WriteLine("*"); return; }
//    if (i != count && j != count)
//    {
//        Console.Write("-");
//        int t = i + 1;
//        StepTest(t, j, count);



//           int y = j + 1;
//        StepTest(i, y, count);        


//        = count && j == count)
//    {
//        Console.Write("-");        
//        int t = i + 1;
//        StepTest(t, j, count);

//        = count && j != count)
//    {
//        Console
//        rite("|");        
//        int t = j + 1;
//        StepTest(i, t, count);
//    }
//}