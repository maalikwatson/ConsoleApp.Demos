// Prompt for input

Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Simple If...Else...statement -- Decide to print pass or fail based on input
// Decide to print pass or fail based on input
Console.WriteLine("***** Simple IF Results *****");
if (grade > 50)
{
    Console.WriteLine("Student has passed.");
}
else
{
    Console.WriteLine("Student has failed.");
    Console.WriteLine("Please recommend student to advisor's office.");
}



/*
 * A: 86 - 100
 * B: 75 - 85
 * C: 65 - 74
 * D: 50 - 64
 * F: < 50
 */
Console.WriteLine("***** Simple IF Results End *****\n\n");

Console.WriteLine("***** Complex IF...ELSE...IF Results *****");
// Decide to print letter grade based on user input

if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid Grade Entry");
}
else if (grade <= 100 && grade >= 86)
{
    Console.WriteLine("A");
}
else if (grade <= 85 && grade >= 75)
{
    Console.WriteLine("B");
}
else if (grade <= 74 && grade >= 65)
{
    Console.WriteLine("C");
}
else if (grade <= 64 && grade >= 50)
{
    Console.WriteLine("D");
}
else if (grade <= 50) 
{
    Console.WriteLine("F");
}

Console.WriteLine("***** Complex IF...ELSE...IF Results End *****");
Console.WriteLine("Thank you for using this program!");

// Ternary operator -- Used to assign a value to a variable based on a condition
Console.WriteLine("***** Ternary Operator Result *****");
string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student Status is: {passStatus}");

Console.WriteLine("***** Ternary Operator Result End *****");


Console.WriteLine("***** Switch Statements *****");
/* 

Console.WriteLine("What day of the week is it?");
Console.WriteLine("1 -- Sunday");
Console.WriteLine("2 -- Monday");
Console.WriteLine("3 -- Tuesday");
Console.WriteLine("4 -- Wednesday (Hump Day!)");
Console.WriteLine("5 -- Thursday");
Console.WriteLine("6 -- Friday");
Console.WriteLine("7 -- Saturday (Beach Day!!!)");

int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek == 1)
{
    Console.WriteLine("Today is Sunday");
}
else if (dayOfWeek == 2)
{
    Console.WriteLine("Today is Monday");
}
else if (dayOfWeek == 3)
{
    Console.WriteLine("Today is Tuesday");
}
else if (dayOfWeek == 4)
{
    Console.WriteLine("Today is Wednesday (Hump Day!)");
}
else if (dayOfWeek == 5)
{
    Console.WriteLine("Today is Thursday");
}
else if (dayOfWeek == 6)
{
    Console.WriteLine("Today is Friday");
}
else if (dayOfWeek == 7)
{
    Console.WriteLine("Today is Saturday (Beach Day!!!)");
}
*/

int dayOfWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        // more code
        // more code
        break;
}

Console.WriteLine("***** Switch Statements End *****");

Console.WriteLine("Thank you for using this program!");

Console.ReadKey();
