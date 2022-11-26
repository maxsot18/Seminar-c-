Console.Write("Enter a number N ");
string InputValue = Console.ReadLine();
int N = Convert.ToInt32(InputValue);
int unN = -N;

while(unN <= N)
{
    Console.Write(unN + " ");
    unN = unN + 1;
}