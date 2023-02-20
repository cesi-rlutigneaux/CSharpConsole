
class Program
{
    static int CalculateSalary(int salary, int tax)
    {
        return (salary * (1-tax/100)) / 12;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Enter your salary before tax: ");
        bool salaryIsInt = int.TryParse(Console.ReadLine(), out int salary);

        if (salaryIsInt)
        {
            Console.WriteLine("Enter the value of tax: ");
            bool taxIsInt = int.TryParse(Console.ReadLine(), out int tax);
            if (taxIsInt)
            {
                int netSalary = CalculateSalary(salary, tax);

                Console.WriteLine("Si votre salaire est de " + salary + "€ et que votre taux d'imposition " +
                    "est de " + tax + "% alors votre net mensuel est de : " + netSalary + "€");
            }
            else
            {
                Console.WriteLine("Sorry but your tax it's not an integer");
            }
        }
        else
        {
            Console.WriteLine("Sorry but your salary it's not an integer");
        }
        Console.ReadLine();
    }
}



