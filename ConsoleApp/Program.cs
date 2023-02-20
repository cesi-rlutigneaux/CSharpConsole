
class Program
{
    static double CalculateSalary(int salary, int tax)
    {
        double tauxPercent = (double)tax/100;
        return salary*(1-tauxPercent)/12;
    }

    static void DisplayElement(int salary, double netSalary, int tax, string[] months)
    {
        Console.WriteLine("Si votre salaire est de " + salary + "€ et que votre taux d'imposition " +
                   "est de " + tax + "% alors votre net mensuel est de : " + netSalary + "€");
        Console.WriteLine("Voici le détail mois par mois");
        foreach (string month in months)
        {
            if (month == months[07])
                continue;

            if (month == months[11])
                netSalary +=  netSalary * 0.1;

            Console.WriteLine(month + " : " + netSalary + "€");
        }
    }

    static void Main(string[] args)
    {
        string[] months = new string[] { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "décembre" };

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Enter your salary before tax: ");
        bool salaryIsInt = int.TryParse(Console.ReadLine(), out int salary);

        if (salaryIsInt)
        {
            Console.WriteLine("Enter the value of tax: ");
            bool taxIsInt = int.TryParse(Console.ReadLine(), out int tax);
            if (taxIsInt)
            {
                double netSalary = CalculateSalary(salary, tax);

                DisplayElement(salary, netSalary, tax, months);
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



