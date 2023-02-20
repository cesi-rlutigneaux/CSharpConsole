
class Program
{
    static double CalculateSalary(int salary, int tax)
    {
        double t = (double)tax/100;
        return salary*(1-t)/12;
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

                Console.WriteLine("Si votre salaire est de " + salary + "€ et que votre taux d'imposition " +
                    "est de " + tax + "% alors votre net mensuel est de : " + netSalary + "€");
                Console.WriteLine("Voici le détail mois par mois");
                foreach (string month in months)
                {
                    Console.WriteLine(month + " : " + netSalary + "€");
                }
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



