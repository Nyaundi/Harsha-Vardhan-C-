class Sample
{
    static void Main()
    {
        //Arithmetic Operators
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b;
        decimal d = a - b;
        decimal e = a * b;
        decimal f = a / b;
        decimal g = a % b;
        System.Console.WriteLine(c);    
        System.Console.WriteLine(d);    
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);

        //Assignemnt operatoros
        a += 20M;
        System.Console.WriteLine(a);

        a -= 20M;
        System.Console.WriteLine(a);

        a *= 3M;
        System.Console.WriteLine(a);

        a /= 3M;
        System.Console.WriteLine(a);
        //Increment /Decrement Operators
        a = 10M;
        System.Console.WriteLine();
        System.Console.WriteLine(++a);
        System.Console.WriteLine(a++);
        System.Console.WriteLine(a);

        System.Console.WriteLine(--a);
        System.Console.WriteLine(a--);
        System.Console.WriteLine(a);

        //Comparison Operators
        //System.Console.WriteLine();
        //System.Console.WriteLine();
        //bool b1 = a == 10;
        //System.Console.WriteLine(b1);
        bool b2 = a != 10;
        System.Console.WriteLine(b2);




        System.Console.ReadKey();
    }
}