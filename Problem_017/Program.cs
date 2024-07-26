// Задача 17.

// Если записать числа от 1 до 5 английскими словами (one, two, three, four, five), то используется всего 3 + 3 + 5 + 4 + 4 = 19 букв.
// Сколько букв понадобится для записи всех чисел от 1 до 1000 (one thousand) включительно?

// Примечание: Не считайте пробелы и дефисы. Например, число 342 (three hundred and forty-two) состоит из 23 букв,
// число 115 (one hundred and fifteen) -из 20 букв.
// Использование "and" при записи чисел соответствует правилам британского английского.

using System.IO;

Dictionary<int, string> numbers = new Dictionary<int, string>();
numbers.Add(0, String.Empty);
numbers.Add(1, "one");
numbers.Add(2, "two");
numbers.Add(3, "three");
numbers.Add(4, "four");
numbers.Add(5, "five");
numbers.Add(6, "six");
numbers.Add(7, "seven");
numbers.Add(8, "eight");
numbers.Add(9, "nine");
numbers.Add(10, "ten");
numbers.Add(11, "eleven");
numbers.Add(12, "twelve");
numbers.Add(13, "thirteen");
numbers.Add(14, "fourteen");
numbers.Add(15, "fifteen");
numbers.Add(16, "sixteen");
numbers.Add(17, "seventeen");
numbers.Add(18, "eighteen");
numbers.Add(19, "nineteen");
numbers.Add(20, "twenty");
numbers.Add(30, "thirty");
numbers.Add(40, "forty");
numbers.Add(50, "fifty");
numbers.Add(60, "sixty");
numbers.Add(70, "seventy");
numbers.Add(80, "eighty");
numbers.Add(90, "ninety");
//numbers.Add(100, "hundred");
//numbers.Add(1000, "thousand");


Console.WriteLine(GetLengthNumber(342));

string longString = string.Empty;
for (int i = 1; i <= 1000; i++)
{

    // 342 mod 10 = 2 => 342 - 2 = 340
    // 340 mod 100 = 40 => 340 - 40 = 300
    // 300 mod 1000 = 0





    if (i >= 1000)
    {
        string strNum = string.Empty;
        int th = i / 1000;
        numbers.TryGetValue(th, out string tmpStr);
        strNum += tmpStr + "thousand";

        Console.WriteLine($"{i} - {strNum}");

        longString += strNum;
    }
    else if (i >= 100)
    {
        string strNum = string.Empty;
        string tmpStr = string.Empty;
        int hn = i % 10;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr;

        hn = (i - hn) % 100;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr;

        if (tmpStr.Length > 0)
            strNum += "and";

        hn = (i - hn) / 100;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr + "hundred";
        Console.WriteLine($"{i} - {strNum}");
        longString += strNum;
    }
    else if (i > 20)
    {
        string strNum = string.Empty;
        string tmpStr = string.Empty;
        int hn = i % 10;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr;

        hn = i - hn;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr;

        Console.WriteLine($"{i} - {strNum}");
        longString += strNum;
    }
    else
    {
        string tmpStr = string.Empty;
        numbers.TryGetValue(i, out tmpStr);
        Console.WriteLine($"{i} - {tmpStr}");
        longString += tmpStr;
    }
}


int GetLengthNumber(int i)
{
    string longString = string.Empty;
    if (i >= 1000)
    {
        string strNum = string.Empty;
        int th = i / 1000;
        numbers.TryGetValue(th, out string tmpStr);
        strNum += tmpStr;

        longString += strNum;
    }
    else if (i >= 100)
    {
        string strNum = string.Empty;
        string tmpStr = string.Empty;
        int hn = i % 10;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr;

        hn = (i - hn) % 100;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr;

        if (tmpStr.Length > 0)
            strNum += "and";

        hn = (i - hn) / 100;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr + "hundred";

        longString += strNum;
    }
    else if (i > 20)
    {
        string strNum = string.Empty;
        string tmpStr = string.Empty;
        int hn = i % 10;
        numbers.TryGetValue(hn, out tmpStr);
        strNum += tmpStr;

        hn = (i - hn) / 10;
        numbers.TryGetValue(hn, out tmpStr);

        longString += strNum;
    }
    else
    {
        string tmpStr = string.Empty;
        numbers.TryGetValue(i, out tmpStr);
        longString += tmpStr;
    }

    return longString.Length;
}

longString = longString.Trim();
Console.WriteLine(longString.Length);