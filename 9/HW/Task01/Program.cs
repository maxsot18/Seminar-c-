// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void EvenNumbers (int m, int n)
{
    if(m == n && n % 2 > 0)
    {
        return;
    }
    if(m % 2 == 0)
    {
        Console.Write($"{m}\t");
    }
    EvenNumbers(m+1, n);
}

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = Prompt("Enter first number ");
int number2 = Prompt("Enter second number ");
Console.WriteLine($"All even numbers between {number1} and {number2}");
EvenNumbers(number1 , number2);