//class Assignement
//{
//    static void Main()
//    {
//        double pi = 22 / 7;
//        int radius = 7;

//        //Calculation
//        double area = pi * radius * radius;
//        System.Console.WriteLine(area);

//        System.Console.ReadLine();
//    }
//}

//Write a C# program convert a person's height (in feet and inches) to centimeters.

/*
Write a C# program convert a person's height (in feet and inches) to centimeters.
Eg:
feet = 5
inches = 7
output: 170.18 cm

Formula:
1 inch = 2.54 cm
1 feet = 12 inches
*/
using System.ComponentModel;

class Program
{
    static void Main()
    {
        int feet = 5;
        int inches = 7;


        //find tital number of inches based on feet

        int total_inches = (feet * 12) + inches;
        double cm = total_inches * 2.54;

        //Output

        System.Console.WriteLine(cm);
        System.Console.Read();
    }
    
}