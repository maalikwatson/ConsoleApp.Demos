// Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 45;

// Prompt user for input
Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Process data
int workingYearsRemaining = retirementAge - age;

// Output results to user
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");