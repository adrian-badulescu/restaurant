using ConsoleApp1;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class VerifyTable
    {
        [Fact]
        public void VerifyTableOccupancy()
        {

            var t = new Table(5);
            //t.tableId = 9;

            t.totalSeatsOfTable = 10;
            t.takenSeats = 5;


            Assert.Equal(50, t.tableocupancy());
        }
        [Fact]
        public void VerifyTableStateOccupied()
        {

            var t = new Table(5);
            //t.tableId = 9;

            t.totalSeatsOfTable = 10;
            t.takenSeats = 5;


            Assert.Equal(tableState.occupied, t.TableState());
        }
        [Fact]
        public void VerifyTableStateFree()
        {

            var t = new Table(5);
            //t.tableId = 9;

            t.totalSeatsOfTable = 10;
            t.takenSeats = 0;


            Assert.Equal(tableState.free, t.TableState());
        }



    }
}
