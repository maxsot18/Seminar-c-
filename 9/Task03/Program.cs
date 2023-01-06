// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumOfNumbers (int number)
{
    int sum = 0;
    while(number % 10 > 0) //&& number / 10 > 0)
    {
        int n = number % 10;
        sum += n;
        number = number / 10;

    }
    Console.WriteLine($"sum of numbers = {sum}");
}
int n = Prompt("Enter a number ");
SumOfNumbers(n);
