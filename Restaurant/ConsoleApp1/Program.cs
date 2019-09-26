using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Room section

            Console.WriteLine("Create a new room, plese enter the numeric id: ");
            var r = new Room(Convert.ToInt32(Console.ReadLine()));


            bool confirmed = false;
            //Table[] TablesArray = new Table[100];
            Table t;
            List<Table> TablesLst = new List<Table>(); // could 
            do
            {
                Console.Write("Enter the taken table Id (string): ");

                t = new Table(Console.ReadLine());

                Console.Write("Add another table y? [y/n] ");
                Console.WriteLine("You entered, " + t.tableId + " as your table id !");

                ConsoleKey response;
                do
                {
                    
                    response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
                    if (response != ConsoleKey.Enter)
                        Console.WriteLine();

                } while (response != ConsoleKey.Y && response != ConsoleKey.N);

                confirmed = response == ConsoleKey.N;
                TablesLst.Add(t);


            } while (!confirmed);

            Console.WriteLine("These are the created tables");

            foreach (var table in TablesLst)
            {
               
                Console.WriteLine("############################");
                Console.WriteLine("Table: " + table.tableId);
                Console.WriteLine("############################");
            }






            //Table section

            //Console.Write("Enter the taken table Id: ");
            //var t = new Table(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter how many seats have the table: ");
            t.totalSeatsOfTable = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter how many persons: ");
            t.takenSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("###############################################");
            Console.WriteLine("         % ocupare " + t.Tableocupancy());
            Console.WriteLine("###############################################");
            Console.WriteLine("");
            Console.WriteLine("The table state is: " + t.TableState());






            //r.tables.Add(t);

            foreach (var ts in r.TablesState())
            {

                //                Console.WriteLine(ts.Key +","+ts.Value);
                Console.WriteLine($"idtable={ts.Key} state={ts.Value}");


            }


            // Waiter section

            // 2nd arg of Waiter should be "P" - available ; "A" - absent from work
            Console.WriteLine("Please enter waiter's name and press Enter \nfollowed by 'P' if is working today or 'A' if not an press Enter : ");
            var w = new Waiter(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("Please enter the total number of waiters: ");
            w.totalWaitersOfRestaurant = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(w.WaiterState());        

            //Console.WriteLine("% presence" + w.presenceAtWork());
            w.waiters.Add(w);


            foreach (var ws in w.WaitersState())
            {
                Console.WriteLine($"idWaiter={ws.Key} state={ws.Value}");
            }



            Console.ReadLine();
        }
    }
}
