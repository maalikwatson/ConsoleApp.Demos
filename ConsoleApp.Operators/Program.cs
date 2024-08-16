// Prompt user to input data
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
 * Math operations
 */

// Add numbers stored in num1 and num2
int sum = num1 + num2;

// Multiply numbers stored in num1 and num2
int product = num1 * num2;

// Divide...
int quotient = num1 / num2;

// Subtraction... 
int difference = num1 - num2;

// Modulus
int mod = num1 % num2;


// Display to console
Console.WriteLine("*****Math Results*****");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Divide: {quotient}");
Console.WriteLine($"Subtraction: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("*****End Math Results*****\n\n");


/*
 * Logical Operations and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine("*****Logical Results*****");
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal To: {isNotEqualTo}");
Console.WriteLine("*****End Logical Results*****\n\n");


/*
 * Assignment Operations and Operators
 */

// int randomValue = 5;
// int increaseValue = num1 + 5
Console.WriteLine("Enter Random Value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*****Assignment Results*****");
num1 += randomValue;
Console.WriteLine($"Num 1 increased by {randomValue}: {num1}");
num1 -= randomValue;
Console.WriteLine($"Num 1 reduecd by {randomValue}: {num1}");
num1 /= randomValue;
Console.WriteLine($"Num 1 divided by {randomValue}: {num1}");
num1 %= randomValue;
Console.WriteLine($"Num 1 mod by {randomValue}: {num1}");
num1 *= randomValue;
Console.WriteLine($"Num 1 multiplied by {randomValue}: {num1}");
Console.WriteLine("*****End Assignment Results*****\n\n");

Console.ReadKey();
