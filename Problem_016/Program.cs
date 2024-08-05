// Задача 16.
// 2^15 = 32768, сумма цифр этого числа равна 3 + 2 + 7 + 6 + 8 = 26.
// Какова сумма цифр числа 2^1000?


string bigNumber = "2";
int degree = 15;

while (degree > 0)
{
    string de = "0";
    for (int n = 0; n < bigNumber.Length; n++)
    {
        // 8 * 2 = 6 -> 1 => 16
        // 16 * 2 = 2 -> 1, 2, 2 + 1 = 3 => 32
        // 148 * 2 = 8 * 2 = 6 -> 1, 4 * 2 = 8, 8 + 1 = 9, 1 * 2 = 2 => 296

        string tempNumber = ((int)(char.GetNumericValue(bigNumber[n]) + char.GetNumericValue(bigNumber[n]) + int.Parse(de))).ToString();

        if (tempNumber.Length > 1)
        {
            de = tempNumber.Substring(0, tempNumber.Length - 1);
            tempNumber = tempNumber.Substring(tempNumber.Length - 1);
        }
    }

    degree--;
}