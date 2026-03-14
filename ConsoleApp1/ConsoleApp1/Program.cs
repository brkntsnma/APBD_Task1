Console.WriteLine("Enter numbers separated by space:");

string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No input provided.");
    return;
}

string[] parts = input.Split(' ');

int[] numbers = parts.Select(int.Parse).ToArray();

Console.WriteLine("You entered " + numbers.Length + " numbers");

Console.WriteLine("Input processed successfully");
