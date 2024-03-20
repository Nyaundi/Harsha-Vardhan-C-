class Program
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
        System.Console.ReadKey();
    }
}