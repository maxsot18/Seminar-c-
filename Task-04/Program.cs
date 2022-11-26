Console.Write("Enter a number ");
string inputValue = Console.ReadLine();
int value = Convert.ToInt32(inputValue);

int CubeValue = value * value * value;
Console.WriteLine("Cube of "+ value + "=" + CubeValue);