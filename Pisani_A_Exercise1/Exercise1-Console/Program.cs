// Alex Pisani CSCI 1630 Assignment 1 Feb 3 2024

using System;

class Program
{
    static void Main()
    {
        // This will store my name
        string programmerName = "Alex Pisani";

        // Constants for labor and installation time
        const double INSTALLATION_COST_PER_HOUR = 35.75;
        const double SQ_FT_PER_HOUR = 40.0;

        // This will display my name
        Console.WriteLine(programmerName + "'s Flooring Cost Calculator");

        // User inputs for floor length, width, and cost per square foot
        Console.Write("Please enter the floor length in feet: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Please enter the floor width in feet: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Please enter the cost per square foot of flooring: ");
        double costPerSqFt = double.Parse(Console.ReadLine());

        // Calculatrd floor area
        int totalSqFt = length * width;

        // Calculates flooring cost
        double materialCost = totalSqFt * costPerSqFt;

        // Calculate total labor hours
        double totalHours = totalSqFt / SQ_FT_PER_HOUR;

        // Calculate total installation cost
        double totalLabor = totalHours * INSTALLATION_COST_PER_HOUR;

        // Calculate total cost (material cost + installation cost)
        double totalCost = materialCost + totalLabor;

        // Output results
        Console.WriteLine("\n--- Floor Cost Breakdown ---");
        Console.WriteLine($"Floor area: {totalSqFt} sq. ft.");
        Console.WriteLine($"Material cost: {materialCost:C}");
        Console.WriteLine($"Installation time: {totalHours}");
        Console.WriteLine($"Installation cost: {totalLabor:C}");
        Console.WriteLine($"Total cost: {totalCost:C}");
    }
}