using System.Reflection.PortableExecutable;
using System.Net.Mime;
using System;
using System.Text;
using System.Linq.Expressions;
// int num = 5;
var array = new int[] { 2, 3, 8, 9, 1 }; //23
int number = 3;
int exponent = 4;
string random = "G3nShiN is Go0d";
var values = new double[2][] { new double[4] { 4.0, 10.5, 0.9, 8.7 }, new double[5] { 2.3, 4.5, 1.2, 12.5, 6.3 } };


// TestProgram.Convert(num);

// var result = TestProgram.FindMinMax(array);
// foreach (var item in result)
// {
//     Console.WriteLine(item);
// }

// var absSum = TestProgram.GetAbsSum(array);
// System.Console.WriteLine(absSum);

// var resultingNum = TestProgram.CalculateExponent(number,exponent);
// System.Console.WriteLine(resultingNum);

// var multipliedNums = TestProgram.MultiplyByLength(array);
// foreach (var num in multipliedNums)
// {
//     System.Console.WriteLine(num);
// }

// System.Console.WriteLine(TestProgram.CountClaps("ClClClaClaClaClap!"));

// var result = TestProgram.ArrayOfMultiples(number, exponent);
// foreach (var numb in result)
// {
//     System.Console.WriteLine(numb);
// }


// var result = TestProgram.ReverseCase(random);
// System.Console.WriteLine(result);

// var result = TestProgram.CheckEquality(random, number);
// System.Console.WriteLine(result);

// var result = TestProgram.FindLargest(values);
// foreach (var num in result)
// {
//     Console.WriteLine(num);
// }

// var result = TestProgram.IndexOfCapitals(random);
// foreach (var index in result)
// {
//     System.Console.WriteLine(index);
// }

// Console.WriteLine(TestProgram.CountChars(random)); 

// Console.WriteLine(TestProgram.Collatz(10));

// Console.WriteLine(TestProgram.CounterpartCharCode('è'));

// Console.WriteLine(TestProgram.CountOnes(999));

// double[] initialArr = new double[] { 69, 100, 28, 47, 53, -61, -24 };
// var result = TestProgram.CountPosSumNeg(initialArr);
// foreach (var entry in result)
// {
//     Console.WriteLine(entry);
// }

public static class TestProgram
{

    public static void Convert(int num)
    {
        DateTime date = new DateTime(2000, num, 23);
        var monthName = date.ToString("MMMM");
        System.Console.WriteLine(monthName);
    }

    public static double[] FindMinMax(double[] values)
    {
        var maxValue = values[0];
        var minValue = values[0];

        if (values.Length > 1)
        {
            foreach (var value in values)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
                else if (value < minValue)
                {
                    minValue = value;
                }
            }
        }
        var minMaxNumbers = new double[] { minValue, maxValue };
        return minMaxNumbers;
    }
    public static int GetAbsSum(int[] numbers)
    {
        var sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                numbers[i] = Math.Abs(numbers[i]);
            }
            sum += numbers[i];
        }
        return sum;
    }

    public static long CalculateExponent(long number, long exponent)
    {
        return (long)Math.Pow(number, exponent);
    }

    public static int[] MultiplyByLength(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= arr.Length;
        }
        return arr;
    }

    public static int CountClaps(string txt)
    {
        char[] array = txt.ToCharArray();
        var count = Array.FindAll(array, x => x == 'C').Length;
        return count;
    }

    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] multiplesArr = new int[length];
        for (int i = 0; i < length; i++)
        {
            multiplesArr[i] = num * (i + 1);
        }
        return multiplesArr;
    }

    public static string ReverseCase(string str)
    {
        StringBuilder text = new StringBuilder(str, str.Length);

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            if (char.IsUpper(ch))
            {
                text[i] = char.ToLower(ch);
            }
            else if (char.IsLower(ch))
            {
                text[i] = char.ToUpper(ch);
            }
        }
        return text.ToString();
    }

    public static bool CheckEquality(object a, object b)
    {
        return a.Equals(b);
    }

    public static int[] IndexOfCapitals(string str)
    {
        List<int> indexArr = new List<int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                indexArr.Add(i);
            }
        }
        return indexArr.ToArray();
    }

    public static string Bomb(string txt)
    {
        if (txt.ToLower().Contains("bomb")) return "Duck!!!";
        else return "There is no bomb, relax.";
    }
    public static string HackerSpeak(string str)
    {
        StringBuilder ogMessage = new StringBuilder(str);
        for (int i = 0; i < ogMessage.Length; i++)
        {
            switch (ogMessage[i])
            {
                case 'a':
                    ogMessage[i] = '4';
                    break;
                case 'i':
                    ogMessage[i] = '1';
                    break;
                case 'e':
                    ogMessage[i] = '3';
                    break;
                case 'o':
                    ogMessage[i] = '0';
                    break;
                case 's':
                    ogMessage[i] = '5';
                    break;

            }
        }
        return ogMessage.ToString();
    }

    public static string smallerNum(string n1, string n2)
    {
        if (n1.Length > n2.Length)
        {
            return n2;
        }
        else if (n1.Length == n2.Length)
        {
            if (n1[0] > n2[0])
            {

                return n2;
            }
            else
            {
                return n1;
            }
        }
        else
        {
            return n1;
        }
    }
    public static string NameShuffle(string str)
    {
        StringBuilder modifiedString = new StringBuilder(str, str.Length);
        string firstWord = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                break;
            }
            firstWord += str[i];
        }
        modifiedString.Remove(0, firstWord.Length + 1);
        string returnString = modifiedString + " " + firstWord.ToString();
        return returnString;
    }
    public static int Factorial(int num)
    {
        int f = 1;
        for (int i = num; i >= 1; i--)
        {
            f *= i;
        }
        return f;
    }

    public static string[] ParseArray(object[] arr)
    {
        string[] convertedArr = Array.ConvertAll(arr, element => element.ToString());
        return convertedArr;
    }

    public static double[] FindLargest(double[][] values)
    {
        List<double> largestNumbers = new List<double>();
        foreach (var value in values)
        {
            largestNumbers.Add(value.Max());
        }
        return largestNumbers.ToArray();
    }

    public static string CountChars(string txt)
    {
        char[] distinctCharacters = txt.ToCharArray();

        int characterCounter = 0;
        int digitCounter = 0;

        foreach (var character in distinctCharacters)
        {
            if (Char.IsLetter(character))
            {
                characterCounter++;
            }
            else if (Char.IsDigit(character))
            {
                digitCounter++;
            }
            else
            {
                continue;
            }
        }
        return $"Letters: {characterCounter}, Digits: {digitCounter}";
    }

    public static int Collatz(int num)
    {
        int count = 0;
        while (num != 1)
        {


            if (num % 2 == 0)
            {
                num /= 2;
                count++;
            }
            else if (num % 2 != 0)
            {
                num *= 3;
                num++;
                count++;
            }

        }
        return count;
    }
    public static int CounterpartCharCode(char symbol)
    {
        if (Char.IsLower(symbol))
        {
            return (int)Char.ToUpper(symbol);
        }
        else if (Char.IsUpper(symbol))
        {
            return (int)Char.ToLower(symbol);
        }
        else
        {
            return (int)symbol;
        }
    }

    public static int CountOnes(int i)
    {
        List<int> binaryNum = new List<int>();
        while (i > 0)
        {
            binaryNum.Add(i % 2);
            i /= 2;
        }
        int counter = 0;
        foreach (var one in binaryNum)
        {
            if (one == 1)
            {
                counter++;
            }
        }
        return counter;
    }

    public static int[] CountPosSumNeg(double[] arr)
    {
        int negativeSum = 0;
        int positiveCount = 0;
        int[] operArray = new int[2];

        foreach (var num in arr)
        {
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeSum += (int)num;
            }
            else
            {
                continue;
            }
        }
        operArray[0] = positiveCount;
        operArray[1] = negativeSum;
        return operArray;
    }


































}
