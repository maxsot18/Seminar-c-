Console.Write("inter a first number ");
string inputFirstValue = Console.ReadLine();
int firstvalue = Convert.ToInt32(inputFirstValue);

Console.Write("inter a second number ");
string inputSecondValue = Console.ReadLine();
int secondvalue = Convert.ToInt32(inputSecondValue);

bool squareValue = secondvalue * secondvalue == firstvalue;
Console.WriteLine("is first number square of "+ secondvalue + " ? " + squareValue);
