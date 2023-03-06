using System;
using Body_Mass_Index_Calculator;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
public class BMICalculator
{
    public static void Main(String[] args)
    {
        //CreateHostBuilder(args).Build().Run();

        Console.Write("Choose measurement system (1 for metric, 2 for imperial): ");
        int system = int.Parse(Console.ReadLine());

        double weight, height, bmi;
        string heightUnit, weightUnit;

        if (system == 1) // To input the measurements in metric
        {
            heightUnit = "metres";
            weightUnit = "kilograms";
            //Ask for the input from the user for metric weights
            Console.Write("Enter your height in metres: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Enter your weight in kilograms: ");
            weight = double.Parse(Console.ReadLine());


            calculate_bmi_metric(height, weight); // Calls the function "calculate_bmi_metric" for Calculating the BMI using metric measurements
        }
        else if (system == 2) // To input the measurements in imperial
        {
            heightUnit = "inches";
            weightUnit = "pounds";

            //Ask for the input from the user for imperial weights
            Console.Write("Enter your height in Feet: ");
            double heightFeet = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in inches: ");
            double heightInches = double.Parse(Console.ReadLine());

            Console.Write("Enter your weight in stones: ");
            double weightStones = double.Parse(Console.ReadLine());

            Console.Write("Enter your weight in pounds: ");
            double weightPounds = double.Parse(Console.ReadLine());

            calculate_bmi_imperial(heightFeet, heightInches, weightStones, weightPounds); //Calls the function "calculate_bmi_imperial" for Calculating the BMI using imperial measurements
        }
        else
        {
            Console.WriteLine("Invalid option. Please choose 1 or 2.");
            return;
        }
    }

  /*  public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    }); */

    //Function to parse input and calculate the BMI in metric weights
    static void calculate_bmi_metric(double h, double w)
    {
        double bmi_metric;
        bmi_metric = w / (h * h);
        Console.WriteLine("The BMI calculated is : " + bmi_metric);

        //If-else to check for the BMI conditions
        if (bmi_metric < 18.5)
        {
            Console.WriteLine("Underweight.");
        }
        else if (bmi_metric >= 18.5 && bmi_metric <= 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if (bmi_metric >= 25 && bmi_metric <= 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else if (bmi_metric >= 30 && bmi_metric <= 34.9)
        {
            Console.WriteLine("Obese Class I");
        }
        else if (bmi_metric >= 35 && bmi_metric <= 39.9)
        {
            Console.WriteLine("Obese Class II");
        }
        else if (bmi_metric >= 40)
        {
            Console.WriteLine("Obese Class III");
        }

        Console.WriteLine("If you are Black, Asian or other minority ethnic groups, you have a higer risk. Adult 23. or more are at increased risk Adults 27.5 or more at high risk\r\n");
    }
    //Function to parse input and calculate the BMI in Imperial weights
    static void calculate_bmi_imperial(double heightFeet, double heightInches, double weightStones, double weightPounds)
    {
        double bmi_imperial;
        double height = (heightFeet * 0.3048) + (heightInches * 0.0254);
        double weight = (weightStones * 6.35029) + (weightPounds * 0.45359237);
        bmi_imperial = weight / (height * height);
        Console.WriteLine("The BMI calculated is : " + bmi_imperial);

        //If-else to check for the BMI conditions
        if (bmi_imperial < 18.5)
        {
            Console.WriteLine("Underweight.");
        }
        else if (bmi_imperial >= 18.5 && bmi_imperial <= 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if (bmi_imperial >= 25 && bmi_imperial <= 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else if (bmi_imperial >= 30 && bmi_imperial <= 34.9)
        {
            Console.WriteLine("Obese Class I");
        }
        else if (bmi_imperial >= 35 && bmi_imperial <= 39.9)
        {
            Console.WriteLine("Obese Class II");
        }
        else if (bmi_imperial >= 40)
        {
            Console.WriteLine("Obese Class III");
        }

        Console.WriteLine("If you are Black, Asian or other minority ethnic groups, you have a higer risk. Adult 23. or more are at increased risk Adults 27.5 or more at high risk\r\n");
    }

}