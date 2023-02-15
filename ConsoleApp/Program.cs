
class Program
{
    static void Square(int a, int b)
    {
        a = a + 1;
        b++;
        a = a * a;
        b *= b;
        Console.WriteLine(a + " " + b);
    }
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;
        Console.WriteLine(num1 + " " + num2);
        Square(num1, num2);
        Console.WriteLine(num1 + " " + num2);
        Console.WriteLine("Press Enter Key to Exit..");
        Console.ReadLine();
    }
}



