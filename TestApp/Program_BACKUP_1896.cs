<<<<<<< HEAD
﻿//class Sample
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
=======
﻿class Program
{
    static void Main()
    {
        int marks = 75; //declare the bvariable to store the marks of the students
        char gradeLetter;

        //>= 85 - 0
        //>= 60 && <85 A
        //>== 50 && < 60 B
        //>35 && < 50 C
        //else F

        if (marks >= 85)
        {
            gradeLetter = 'O';
        }
        else if (marks >=60 && marks <85)
        {
            gradeLetter = 'A';
        }
        else if (marks >= 50 && marks< 60)
        {
            gradeLetter = 'C';
        }
        else
        {
            gradeLetter = 'F';
        }

        System.Console.WriteLine(gradeLetter);
>>>>>>> c934fe0731b173e34d09648d3f0512e7a73e8353
        System.Console.ReadKey();
    }
}