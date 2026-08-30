//Implicit Type Conversion in C#
int number = 42;
double convertedNumber = number;

// Explicit Type Conversion in C#
double number2 = 3.14;
int convertedNumber2 = (int)number2; 

Console.WriteLine("Enter a number:");
string? input = Console.ReadLine();

//Parse
int number3 = int.Parse(input);

//TryParse
bool isParsed = int.TryParse(input, out int number4);

if (isParsed)
{
    Console.WriteLine($"Parsed number: {number4}");
}
else
{
    Console.WriteLine("Failed to parse the input.");
}

//Conversion methods
int number5 = 100;
string convertedString = System.Convert.ToString(number5);
Console.WriteLine(convertedString);