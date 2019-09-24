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
        public double calc;

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






        public double Tableocupancy()
        {
            // this must be refactored as else if statement is not working
            try
            {
                calc = Convert.ToDouble(takenSeats) / Convert.ToDouble(totalSeatsOfTable) * 100;
                //return calc;
            }
            catch (Exception e)
            {
                if (e is DivideByZeroException)
                {
                    Console.WriteLine(e.Message);
                    
                }
                else if (e is FormatException)
                {
                    Console.WriteLine(e.Message);
                    
                }
                else
                {
                    throw;
                }


            }
            return calc;


        }
    }
}
