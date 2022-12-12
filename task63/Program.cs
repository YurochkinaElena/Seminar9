// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке  от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"



System.Console.WriteLine(PrintNumbers(1, 10));
string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + " " + PrintNumbers(++start, end));
}