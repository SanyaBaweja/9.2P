using System;
using System.Numerics;

namespace Iteration6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the description of your player: ");
            string description = Console.ReadLine();

            Player p = new Player(name, description);

            Location l = new Location("Hallway", "This is a long well lit hallway");
            Location l2 = new Location("India", "This is my beautiful country");

            Item gem = new Item(new string[] { "gem" }, "gem", "A bright Kohinoor gem");
            Item sword = new Item(new string[] { "sword" }, "sword", "Maharana Pratap's sword");

            Bag b = new Bag(new string[] { "bag" }, "bag", "That is a Louis Vuitton bag");
            Bag b2 = new Bag(new string[] { "bag2" }, "bag2", "That is a costly Versache bag");

            Item money = new Item(new string[] { "money" }, "money", "20,00,00,000 Rupees");

            Path india = new Path(new string[] { "north", "n" }, "north", "Northways", l);
            Path hall = new Path(new string[] { "south", "s" }, "south", "Southways", l2);

            CommandProcessor c = new CommandProcessor();

            p.Inv.Put(gem);
            p.Inv.Put(sword);

            p.Inv.Put(b);
            p.Inv.Put(b2);

            l.Inv.Put(gem);

            b2.Inv.Put(money);

            l.Inv.Put(sword);
            l2.Inv.Put(money);

            l.AddPathInList(hall);
            
            l2.AddPathInList(india);
            p.Loc = l;

            bool exit = false;

          

            while (!exit)
            {
                Console.WriteLine("\nType your command:");
                string command = Console.ReadLine().ToLower();
                if (command == "exit")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine(c.Execute(p, command.Split()));
                }
            }
        }
    
    }
}




