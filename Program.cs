using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose measurement system (1 for metric, 2 for imperial): ");
            int system = int.Parse(Console.ReadLine());

            double height, weight, bmi;
            string heightUnit, weightUnit;

            if (system == 1) // metric
            {
                heightUnit = "meters";
                weightUnit = "kilograms";

                Console.Write("Enter your height in meters: ");
                height = double.Parse(Console.ReadLine());

                Console.Write("Enter your weight in kilograms: ");
                weight = double.Parse(Console.ReadLine());
            }
            else if (system == 2) // imperial
            {
                heightUnit = "inches";
                weightUnit = "pounds";

                Console.Write("Enter your height in inches: ");
                double heightInches = double.Parse(Console.ReadLine());

                Console.Write("Enter your weight in pounds: ");
                double weightPounds = double.Parse(Console.ReadLine());

                height = heightInches * 0.0254; // convert to meters
                weight = weightPounds * 0.453592; // convert to kilograms
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose 1 or 2.");
                return;
            }

            bmi = weight / (height * height);

            Console.WriteLine("Your BMI is: " + bmi.ToString("F2") + ".");
            Console.WriteLine("Your height is: " + height.ToString("F2") + " " + heightUnit + ".");
            Console.WriteLine("Your weight is: " + weight.ToString("F2") + " " + weightUnit + ".");

            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("Your weight is normal.");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }

            Console.ReadLine();
        }
    }
}