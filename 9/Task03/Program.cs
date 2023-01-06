// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumbers(int number)
{

    if (number == 0)
    {
        return 0;
    }
    
    return number % 10 + SumOfNumbers(number / 10);
}
int n = Prompt("Enter a number ");
Console.WriteLine(SumOfNumbers(n));
