// Task 1: Find odd numbers

Console.Write("Input numbers separated by spaces: ");
string input = Console.ReadLine();

string[] numberStrings = input.Split(' ');

Console.WriteLine("The odd numbers are: ");

foreach (string numberString in numberStrings)
{
    int number;
    if (int.TryParse(numberString, out number))
    {
        if (number % 2 == 1)
        {
            Console.WriteLine(number);
        }
    }
    else
    {
        Console.WriteLine($"'{numberString}' is not a valid number.");
    }
}