// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNaturalNumbers(int n, int m)
{
    if (m == n)
    {
        return m;
    }
    return n + SumOfNaturalNumbers(n +1, m);
    
}
int num1 = Prompt("Enter a first number ");
int num2 = Prompt("Enter a second number ");
Console.WriteLine($"Sum of natural numbers Between {num1} and {num2} is {SumOfNaturalNumbers(num1, num2)}");