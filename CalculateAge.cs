using System;

public class CalculateAge
{
    /*Create a function that takes the age in years and returns the age in days.

    CalcAge(65) ➞ 23725

    CalcAge(0) ➞ 0

    CalcAge(20) ➞ 7300
    */

    public static void CalcAge(int years)
    {
        years *= 365;
        Console.WriteLine(years);
    }

    public static void Main(string[] args)
    {
        CalcAge(65);    //Outputs: 23725
        CalcAge(0);     //Outputs: 0
        CalcAge(20);    //Outputs: 7300
    }
}
