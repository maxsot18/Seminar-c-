// Задача 2: Задайте значения M и N. Напишите программу, 
// которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8


int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int m, int n)
{
    while (m < n)
    {
        
        Console.WriteLine(m);
        m++;
    }
    Console.WriteLine(n);
    
}

int number1 = Prompt("Enter a first number ");
int number2 = Prompt("Enter a second number ");
Console.WriteLine();
PrintNumbers(number1, number2);


