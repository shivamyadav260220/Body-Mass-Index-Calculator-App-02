using System;

Console.Write("Choose measurement system (1 for metric, 2 for imperial): ");
int system = int.Parse(Console.ReadLine());

double weight, height, bmi;
string heightUnit, weightUnit;

if (system == 1) // To input the measurements in metric
{
    heightUnit = "metres";
    weightUnit = "kilograms";

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
static void calculate_bmi_metric(double h, double w)
{
    double bmi_metric;
    bmi_metric = w / (h * h);
    Console.WriteLine("The BMI calculated is : " + bmi_metric);
    if (bmi_metric < 18.5)
    {
        Console.WriteLine("You are underweight.");
    }
    else if (bmi_metric >= 18.5 && bmi_metric <= 24.9)
    {
        Console.WriteLine("Your weight is normal.");
    }
    else if (bmi_metric >= 25 && bmi_metric <= 29.9)
    {
        Console.WriteLine("You are overweight.");
    }
    else
    {
        Console.WriteLine("You are obese.");
    }
}

static void calculate_bmi_imperial(double heightFeet, double heightInches, double weightStones, double weightPounds)
{
    double bmi_imperial;
    double height = (heightFeet * 0.3048) + (heightInches * 0.0254);
    double weight = (weightStones * 6.35029) + (weightPounds * 0.45359237);
    bmi_imperial = weight / (height * height);
    Console.WriteLine("The BMI calculated is : " + bmi_imperial);
    if (bmi_imperial < 18.5)
    {
        Console.WriteLine("You are underweight.");
    }
    else if (bmi_imperial >= 18.5 && bmi_imperial <= 24.9)
    {
        Console.WriteLine("Your weight is normal.");
    }
    else if (bmi_imperial >= 25 && bmi_imperial <= 29.9)
    {
        Console.WriteLine("You are overweight.");
    }
    else
    {
        Console.WriteLine("You are obese.");
    }
}
