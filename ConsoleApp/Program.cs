
class Program
{
    static int CalculateSalary(int salary, int tax)
    {
        return (salary * (1-tax/100)) / 12;
    }

    static void Main(string[] args)
    {
        //int salary = int.Parse(args[0]);
        //int tax = int.Parse(args[1]);
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Enter your salary before tax: ");
        int salary = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of tax: ");
        int tax = int.Parse(Console.ReadLine());

        int netSalary = CalculateSalary(salary, tax);

       

        Console.WriteLine("Si votre salaire est de " + salary + "€ et que votre taux d'imposition " +
            "est de " + tax + "% alors votre net mensuel est de : " + netSalary + "€");

        Console.ReadLine();
    }
}



