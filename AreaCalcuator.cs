using System;

public class AreaCalcuator
{
    static double Rect(double length, double width)
    {
        return length * width;
    }

    static double Circle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    static double Trian(double bottom, double height)
    {
        double halfFive = 0.5;
        return halfFive * bottom * height;
    }

    static double CalCityArea(double Arrectangle, double Arcircle, double Artriangle)
    {
        return Arrectangle + Arcircle + Artriangle;
    }

    static double CalFloCost(double areaCost, double pesoCost = 180)
    {
        return areaCost * pesoCost;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Rect(750, 500));
        Console.WriteLine(Circle(375));
        Console.WriteLine(Trian(750, 500));

        Console.WriteLine("The Total Area is: " + CalCityArea(Rect(750, 500), Circle(375), Trian(750, 500)));
        Console.WriteLine($"The total cost of remodeling the city will be: {CalFloCost(CalCityArea(Rect(750, 500), Circle(375), Trian(750, 500)), 200)}");
    }
}
