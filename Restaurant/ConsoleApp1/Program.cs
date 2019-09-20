using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var x = Console.ReadLine();
            //Console.WriteLine("am citit " + x);

            var t = new Table(5);
            //t.tableId = 9;

            t.totalSeatsOfTable = 10;
            t.takenSeats = 5;
            
            Console.WriteLine("% ocupare" + t.tableocupancy());
            Console.WriteLine(t.TableState());

            var r = new Room(1);
            r.tables.Add(t);
            
            foreach(var ts in r.TablesState())
            {

//                Console.WriteLine(ts.Key +","+ts.Value);
                Console.WriteLine($"idtable={ts.Key} state={ts.Value}");


            }




        }
    }
}
