// Task 2: write a program that solves the quadratic equation: ax2+bx+c=0

Console.Write("Enter coefficient a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coefficient b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coefficient c: ");
double c = Convert.ToDouble(Console.ReadLine());

double discriminant = b * b - 4 * a * c;

if (discriminant > 0)
{
    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine("The equation has two real and distinct roots:");
    Console.WriteLine($"Root 1: {root1}");
    Console.WriteLine($"Root 2: {root2}");
}
else if (discriminant == 0)
{
    double root = -b / (2 * a);
    Console.WriteLine("The equation has one real root:");
    Console.WriteLine($"Root: {root}");
}
else
{
    double realPart = -b / (2 * a);
    double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
    Console.WriteLine("The equation has two complex roots:");
    Console.WriteLine($"Root 1: {realPart} + {imaginaryPart}i");
    Console.WriteLine($"Root 2: {realPart} - {imaginaryPart}i");
}