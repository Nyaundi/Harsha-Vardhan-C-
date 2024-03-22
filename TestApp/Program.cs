//class Sample
//{
//    static void Main()
//    {
//        //Arithmetic Operators
//        decimal a = 10M;
//        decimal b = 3M;
//        decimal c = a + b;
//        decimal d = a - b;
//        decimal e = a * b;
//        decimal f = a / b;
//        decimal g = a % b;
//        System.Console.WriteLine(c);    
//        System.Console.WriteLine(d);    
//        System.Console.WriteLine(e);
//        System.Console.WriteLine(f);
//        System.Console.WriteLine(g);

//        //Assignemnt operatoros
//        a += 20M;
//        System.Console.WriteLine(a);

//        a -= 20M;
//        System.Console.WriteLine(a);

//        a *= 3M;
//        System.Console.WriteLine(a);

//        a /= 3M;
//        System.Console.WriteLine(a);
//        //Increment /Decrement Operators
//        a = 10M;
//        System.Console.WriteLine(++a);
//        System.Console.WriteLine(a++);
//        System.Console.WriteLine(a);

//        //Concatenation Operator
//        string name = "Scott";
//        int age = 10;
//        string message = "Hey, " + name + ", your age is " + age;
//        System.Console.WriteLine(message);


//        //ternary operator
//        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
//        System.Console.WriteLine(title);

//        //operator precedence
//        double z = 10 + 4 * 30 / 10;
//        System.Console.WriteLine(z);
//        System.Console.ReadKey();
//    }
//}

class Program
{
    static void Main()
    {
        //variable to store greade letter of student
        char gradeLetter = 'B';

        //find out the description based on grade letter
        string gradeDescription;
        switch(gradeLetter)
        {
            case 'O':gradeDescription = "Outstanding";break;
            case 'A': gradeDescription = "Excellent"; break;
            case 'B': gradeDescription = "good"; break;
            case 'C': gradeDescription = "Average"; break;
            case 'F': gradeDescription = "Fail"; break;
            default:gradeDescription = "None";break;
        }
        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();
    }
}