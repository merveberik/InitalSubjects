using System;

namespace Customer_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Cust cust1 = new Cust();
            Console.WriteLine("Please, add a customer name:");
            cust1.Name = Console.ReadLine();

            Console.WriteLine("Do you want to continue; Y or N?");
            Decision:
            string userdecision = (Console.ReadLine().ToUpper());
            switch (userdecision)
            {
                case "Y":
                    goto Start;
                case "N":
                    break;
                default:
                    Console.WriteLine("your choice is invalid.");
                    goto Decision;

            }
            Console.WriteLine(cust1.Name);
        }
    }
}
