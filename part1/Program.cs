//System for calculating Angles between hours and minutes

using System;

namespace ClockAngleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input for hours and minutes
            Console.Write("Enter the hour (0-12): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the minutes (0-59): ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            // Calculate the smaller angle between the hour and minute hands
            double hourAngle = 0.5 * (60 * hour + minutes);
            double minuteAngle = 6 * minutes;
            double angle = Math.Abs(hourAngle - minuteAngle);

            // Ensure the smaller angle is considered
            if (angle > 180)
                angle = 360 - angle;

            // Display the result
            Console.WriteLine($"The smaller angle between the hour and minute hands is: {angle} degrees");
            Console.ReadKey();
        }
    }
}
