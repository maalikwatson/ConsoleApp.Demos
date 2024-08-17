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



Console.ReadKey();
