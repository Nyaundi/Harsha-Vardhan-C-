//Write a program to find out "category of height" based on the given height of a person (in inches), using "if".


class Program
{
    static void Main()
    {
        int height_in_inches = 75;
        double height_in_cm = height_in_inches * 2.54; //To convert height from cm to inches
        string result = null;

        //check the height and find the height category accordingly
        if (height_in_cm <= 150)
            result = "Dwarf";
        else if (height_in_cm >= 150 && height_in_cm <= 165)
            result = "Average Height";
        else if (height_in_cm > 165 && height_in_cm <= 195)
            result = "Tall";
        else
            result = "Abnormal Height";

        System.Console.WriteLine(result);
        System.Console.ReadKey();



    }
}