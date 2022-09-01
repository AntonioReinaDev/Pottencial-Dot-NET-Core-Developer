using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = 18;
            double height = 1.80;
            decimal price = 1.80m;
            bool condition = true;

            Console.WriteLine($" {quantity} \n {height.ToString("0.00")} \n {price} \n {condition} \n");

            quantity = 25;
            Console.WriteLine(quantity);

            DateTime currentDateTest = DateTime.Now.AddDays(5);
            DateTime currentDate = DateTime.Now;

            Console.WriteLine(currentDateTest.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));

            Console.ReadKey();

        }
    }
}
