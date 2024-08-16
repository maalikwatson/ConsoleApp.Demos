// Declare variables
string? firstName = string.Empty;
string? lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;

// Prompt user for input
Console.WriteLine("*****RETIREMENT CALCULATOR*****\n\n");
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you employed? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

Console.Write("\n\n");

Console.WriteLine("_______________________________________\n\n");

// Process data
int workingYearsRemaining = retirementAge - age;

// Output results to user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"Your employment status: {working}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");

Console.ReadKey();