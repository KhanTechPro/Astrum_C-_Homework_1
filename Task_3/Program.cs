// Task 3: Create a program that determines a zodiac sign based on the user's birth month and day

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Enter your birth month (1-12):");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your birth day (1-31):");
int day = Convert.ToInt32(Console.ReadLine());

string zodiacSign = GetZodiacSign(month, day);
Console.WriteLine($"{name}, your zodiac sign is: {zodiacSign}");

static string GetZodiacSign(int month, int day)
{
    if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
        return "Crow (20.1-18.2)";
    else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
        return "Fish (19.2-20.3)";
    else if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
        return "Sheep(21.3-19.4)";
    else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
        return "Calf(20.4-20.5)";
    else if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
        return "Gemini(21.5-21.6)";
    else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
        return "Crab(22.6) -22.7)";
    else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
        return "Leo(23.7-22.8)";
    else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
        return "Sunrise(23.8-22.9)";
    else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
        return "Libra(23.9-22.10)";
    else if ((month == 10 && day >= 23) || (month == 11 && day <= 22))
        return "Scorpio(23.10-22.11)";
    else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
        return "Sagittarius(23.11-21.12)";
    else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
        return "Goat(22.12 -19.1)";
    else
        return "Invalid date";
}