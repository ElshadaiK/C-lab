using System;

namespace Question18
{
    class Program
    {
        static void Main(string[] args)
        {   
            double charge;
            double surcharge = 0.0;

            Console.Write("Input Customer ID :");
            int id= Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            string name = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            int unit = Convert.ToInt32(Console.ReadLine());

            if (unit < 200) charge = 1.2;
            else if (unit >= 200 && unit < 400) charge = 1.5;
            else if (unit >= 400 && unit < 600) charge = 1.8;
            else charge = 2.0;

            double amountCharges = charge * unit;
            if (amountCharges > 400) {
                surcharge = amountCharges * 0.15;
            }
            double netAmount = amountCharges + surcharge;

            Console.WriteLine($"Customer Id No: {id}");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Unit Consumed: {unit}");
            Console.WriteLine($"Amount Charges @Rs {charge} per unit: {amountCharges}");
            Console.WriteLine($"Surcharge Amount: {surcharge}");
            Console.WriteLine($"Net amount paid by the customer: {netAmount}");
        }
    }
}
