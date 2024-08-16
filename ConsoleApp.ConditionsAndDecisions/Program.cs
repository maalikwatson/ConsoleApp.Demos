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


Console.WriteLine("***** Simple IF Results End *****\n\n");

Console.WriteLine("***** Complex IF...ELSE...IF Results *****");

if (grade < 50)
{
    Console.WriteLine("Student has failed -- F");
}
else if (grade == 65)
{
    Console.WriteLine("C+");
}
else if (grade == 75)
{
    Console.WriteLine("B");
}
else if (grade == 85)
{
    Console.WriteLine("B+");
}
else
{
    Console.WriteLine("A -- Good Job!");
}



Console.WriteLine("***** Complex IF...ELSE...IF Results End *****");


Console.WriteLine("Thank you for using this program!");



Console.ReadKey();
