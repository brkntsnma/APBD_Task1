Console.WriteLine("Enter numbers separated by space:");

string input = Console.ReadLine();

string[] parts = input.Split(' ');

int[] numbers = parts.Select(int.Parse).ToArray();

Console.WriteLine("You entered " + numbers.Length + " numbers");