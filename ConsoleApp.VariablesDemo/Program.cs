//Different data types

/* 
 * text - string
 * integers - int
 * decimal - double, float, decimal
 * logical - boolean
 */

string name = "Maalik Watson";
Console.WriteLine(name);

Console.WriteLine("I am " + name); // string concatenation
Console.WriteLine($"They call me {name}."); // string interpolation
Console.WriteLine("I was given the name {0}.", name); // formatted string

int age = 32;
int retirementYearsLeft = 4;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retierment age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);