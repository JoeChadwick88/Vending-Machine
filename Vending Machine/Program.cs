using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class Program
    {
        struct product
        {
            public string name;
            public double price;
        }
        static void Main(string[] args)
        {
            product[] machine = new product[10];
            LoadItems(machine);
            DisplayItems(machine);

        }
        static void LoadItems(product[] machine)
        {
            machine[0].name = "Twix";
            machine[0].price = 0.80;
            machine[1].name = "KitKat";
            machine[1].price = 0.80;
            machine[2].name = "Snickers";
            machine[2].price = 0.80;
            machine[3].name = "Mars Bar";
            machine[3].price = 0.80;
            machine[4].name = "crisps";
            machine[4].price = 0.50;
            machine[5].name = "Pepsi";
            machine[5].price = 1.00;
            machine[6].name = "coke";
            machine[6].price = 1.00;
            machine[7].name = "Haribo";
            machine[7].price = 1.50;
            machine[8].name = "Dairy Milk";
            machine[8].price = 0.90;
            machine[9].name = "Yorkie";
            machine[9].price = 0.80;


        }
        static void DisplayItems(product[] machine)
        {
            for (int i = 0; i < machine.Length; i++)
            {
                Console.WriteLine(machine[i].name+" £" + machine[i].price);
            }
        }
    }
}
