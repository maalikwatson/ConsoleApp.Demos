﻿// Declare variables
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt user for input
Console.WriteLine("Please enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Process data
int workingYearsRemaining = retirementAge - age;

// Output results to user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");