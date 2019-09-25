﻿using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the taken table Id: ");
            var t = new Table(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter how many seats have the table: ");
            t.totalSeatsOfTable = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter how many persons: ");
            t.takenSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("% ocupare" + t.Tableocupancy());




            //t.tableId = 9;





            Console.WriteLine(t.TableState());

            var r = new Room(1);
            r.tables.Add(t);
            
            foreach(var ts in r.TablesState())
            {

//                Console.WriteLine(ts.Key +","+ts.Value);
                Console.WriteLine($"idtable={ts.Key} state={ts.Value}");


            }



            // 2nd arg of Waiter should be "P" - available ; "A" - absent from work

            Console.WriteLine("Please enter waiter's name and press Enter \nfollowed by 'P' if is working today or 'A if not an press Enter' : ");
            var w = new Waiter(Console.ReadLine(), Console.ReadLine());
            
            Console.WriteLine(w.WaiterState());



            w.totalWaitersOfRestaurant = 10;
            w.absentwaiters = 2;

            Console.WriteLine("% presence" + w.presenceAtWork());

            

            foreach (var ws in w.WaitersState())
            {

                
                Console.WriteLine($"idWaiter= {ws.Key} state= {ws.Value}");


            }
            Console.ReadLine();
        }
    }
}
