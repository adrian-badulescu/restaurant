using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ConsoleApp1 {
public class Waiter
{


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