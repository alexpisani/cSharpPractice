using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt the user to input a grade point
        Console.WriteLine("Please enter your grade (0 to 100): ");

        // Read input
        string input = Console.ReadLine();

        // Try to parse the input as an integer, ensuring it's within the correct range
        if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
        {
            string letterGrade = GetLetterGrade(grade);
            // Display the result in an ASCII box format
            DisplayGradeBox(grade, letterGrade);
        }
        else
        {
            // Handle invalid inputs
            Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
        }
    }

    static string GetLetterGrade(int grade)
    {
        if (grade >= 88)
            return "A";
        else if (grade >= 80)
            return "B";
        else if (grade >= 68)
            return "C";
        else if (grade >= 60)
            return "D";
        else
            return "F";
    }

    static void DisplayGradeBox(int grade, string letterGrade)
    {
        // Calculate the length of the top and bottom lines of the box
        int boxWidth = 27;

        // Print top border
        Console.WriteLine("{0,-12}   {1,-12}", new string('=', 12), new string('=', 12));

        // Print the  title
        Console.WriteLine("|{0,-12}  {1,-12}|", "Grade Point", "Letter Grade");

        // Print the separator line
        Console.WriteLine("{0,-12}   {1,-12}", new string('=', 12), new string('=', 12));

        // Print the values
        Console.WriteLine("|{0,-12}  {1,-12}|", grade, letterGrade);

        // Print bottom border
        Console.WriteLine(new string('=', boxWidth));
    }
}
