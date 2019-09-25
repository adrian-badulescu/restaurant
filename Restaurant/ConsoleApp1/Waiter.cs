using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ConsoleApp1 {
public class Waiter
    {
        public enum waiterState
        {
            available = 1,
            absent = 2,
            notset = 3
        }
        public string waiterId { get; private set; }
        public double totalWaitersOfRestaurant { get; set; }
        public double absentwaiters { get; set; }
        public string setWaiterAvailability { get; private set; }

         


    public waiterState WaiterState()
        {                        
            if ( setWaiterAvailability == "P")
            {
                return waiterState.available;
            }
            else if ( setWaiterAvailability == "A")
            {
                return waiterState.absent;
            }
            else
            {
                return waiterState.notset;
            }
        }

     






        public double presenceAtWork()
        {
            double presence = absentwaiters  / totalWaitersOfRestaurant * 100;
            return presence;
        }


        
        public Dictionary<string, waiterState> WaitersState()
        {
            var waiterWithState = this.waiters.Select(Waiter =>
            {
                return new { id = Waiter.waiterId, state = Waiter.WaiterState() };
            });
            var ret = new Dictionary<string, waiterState>();
            foreach (var w in waiterWithState)
            {
                ret.Add(w.id, w.state);
            }
            //ret.ToList().ForEach(x => Console.WriteLine( x.Value));
            return ret;
            
        }

        public List<Table> assingedTables { get; set; }
        public List<Waiter> waiters { get; set; }


        public Waiter(string _waiterId, string _setWaiterAvailability)
        {
            this.waiterId = _waiterId;
            this.waiters = new List<Waiter>();
            this.setWaiterAvailability = _setWaiterAvailability;

        }


    }
} 