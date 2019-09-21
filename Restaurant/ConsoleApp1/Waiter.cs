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
            absent = 2
        }


        public int totalWaitersOfRestaurant { get; set; }

        public int absentwaiters { get; set; }

        public int presenceAtWork()
        {
            var presence = (absentwaiters * 100) / totalWaitersOfRestaurant;
            return presence;
        }



        public Dictionary<int, waiterState> waiterState()
        {
            var waiterWithState = this.waiters.Select(Waiter =>
            {
                return new { id = Waiter.waiterId, state = Waiter.waiterState() };
            });
            var ret = new Dictionary<int, waiterState>();
            foreach (var w in waiterWithState)
            {
                ret.Add(w.id, w.state);
            }

            return ret;

        }

        //public List<Table> assingedTables;

        public string waiterId { get; private set; }
        
        public Waiter(string _waiterId)
        {
            this.waiterId = _waiterId;
            this.waiters = new List<Waiter>();
                       
        }

        
        public List<Waiter> waiters { get; set; }



       
    }
} 