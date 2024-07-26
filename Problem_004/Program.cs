// Задача 4.

// Число - палиндром с обеих сторон (справа налево и слева направо) читается одинаково.
// Самое большое число-палиндром, полученное умножением двух двузначных чисел – 9009 = 91 × 99.

// Найдите самый большой палиндром, полученный умножением двух трехзначных чисел.

List<int> polindromNumbers = new List<int>();

for (int a = 1; a <= 999; a++)
    for (int b = 1; b <= 999; b++)
        if (IsPolindrom(a * b))
            polindromNumbers.Add(a * b);

Console.WriteLine("Cамый большой палиндром, полученный умножением двух трехзначных чисел равен {0}", polindromNumbers.Max());


bool IsPolindrom(int number)
{
    string stringNumber = number.ToString();

    if (stringNumber.Length == 1) return true;

    int length = stringNumber.Length;

    // Сравниваем первый и последний, второйи и предпоследний и т.д символы
    // до середины строки
    for (int k = 0; k < length / 2; k++)
    {
        if (!stringNumber[k].Equals(stringNumber[length - 1 - k]))
            return false;
    }

    return true;
}


/*
  public void MaxPolindrom()
        {           
            List<int> polindroms = new List<int>();

            for(int x = 999; x > 99; x--)
                for(int y = 999; y > 99; y--)
                {
                    int number = x * y;
                    if(IsPolindrom(number))
                        polindroms.Add(number);
                }

            Console.WriteLine(polindroms.Max());
        }

        private bool IsPolindrom(int number)
        {
            string stringNumber = number.ToString();
           
            for(int i = 0; i < (stringNumber.Length / 2); i++)
            {
                if (!stringNumber[i].Equals(stringNumber[stringNumber.Length - 1 - i]))
                    return false;
            }

            return true;
        }
 
 */