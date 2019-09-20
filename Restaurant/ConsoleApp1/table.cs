using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public enum tableState
    {
        occupied = 1,
        free = 2  
    }
    public class Table
    {
        public Table(int _tableId)
        {

            this.tableId = _tableId;

        }
        public int tableId { get; private set; }

        /// <summary>
        /// if the table is free or not for other persons
        /// </summary>
        public tableState TableState()
        {
            //get
            {
                if (this.takenSeats > 0)
                {

                    
                    return tableState.occupied;
                    

                }
                else
                {
                    return tableState.free;
                }
            }
        }



        /// <summary>
        /// number of seats of table
        /// </summary>
        public int totalSeatsOfTable { get; set; }
        /// <summary>
        /// seats occupied by clients
        /// </summary>
        public int takenSeats { get; set; }





      
        public int tableocupancy()
        { // (1.d.)
            var calc = (this.takenSeats * 100) / this.totalSeatsOfTable;
            return calc;
        }

    }
}
