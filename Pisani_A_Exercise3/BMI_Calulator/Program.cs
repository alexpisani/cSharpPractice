// Alex Pisani CSCI 1630 W01 - Exercise 3 - March 3 2025 

using System;

class Program
{
    // BMI calculation method
    static string GetBmiCategory(double bmi)
    {
        if (bmi < 18.5)
        {
            return "Underweight";
        }
        else if (bmi < 25)
        {
            return "Normal weight";
        }
        else if (bmi < 30)
        {
            return "Overweight";
        }
        else
        {
            return "Obesity";
        }
    }
    static void Main()
    {
        // Title
        Console.WriteLine("BMI and Karvonen Calculator \n");

        Console.WriteLine("Please enter the following values for the user . . . \n");

        // Input Data
        Console.Write("Height in inches: ");
        double heightInInches = double.Parse(Console.ReadLine());

        Console.Write("Weight in pounds: ");
        double weightInPounds = double.Parse(Console.ReadLine());

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Resting heart rate (beats per minute): ");
        int restingHeartRate = int.Parse(Console.ReadLine());

        // Calculate BMI
        double heightInMeters = heightInInches * 0.0254;
        double weightInKilograms = weightInPounds * 0.453592;
        double bmi = weightInKilograms / (heightInMeters * heightInMeters);

        // Determine BMI category
        string bmiCategory = GetBmiCategory(bmi);

        // Output BMI and category
        Console.WriteLine($"\nResults . . .");
        Console.WriteLine($"\nYour BMI is: {bmi:F2} -- {bmiCategory}");

        // Display exercise intensity levels and corresponding maximum heart rates
        Console.WriteLine("\nExercise Intensity and Maximum Heart Rate:\n");
        Console.WriteLine($"Intensity            Max Heart Rate\n");

        for (double intensity = 0.50; intensity < 0.951; intensity += 0.05)
        {
            // Calculate max heart rate based on the Karvonen formula
            int maxHeartRate = 220 - age;
            int heartRateReserve = maxHeartRate - restingHeartRate;
            int targetHeartRate = (int)((heartRateReserve * intensity) + restingHeartRate);

            // Output exercise intensity and calculated target heart rate
            Console.WriteLine($"{intensity * 100:F0}%        --        {targetHeartRate} bpm");
        }
    }
}
