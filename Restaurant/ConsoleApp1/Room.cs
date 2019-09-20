using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
   
    public class Room
    {
        public int roomId;
        //tables: Array<Table>;  // (1.a.)
        //stateOfTables: Array<boolean>;

        public List<Table> tables { get; set; }

        public Room(int id)
        {
            this.tables = new List<Table>();
            // super(id);   
            this.roomId = id;
        }

        public Dictionary<int, tableState> TablesState()
        {
            var tableWithState=this.tables.Select(table =>
            {
                return new { id = table.tableId, state = table.TableState() };
            });
            var ret = new Dictionary<int, tableState>();
            foreach(var t in tableWithState)
            {
                ret.Add(t.id, t.state);
            }

            return ret;

            


        }

        //tablestate()
        //{ // (1.b.)
        //    this.tables.map((table) => {
        //        return { "id": table.tableId, "state": table.state };
        //    });
        //}


    }
}
