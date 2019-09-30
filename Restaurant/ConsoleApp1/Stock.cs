using System;

public class Stock
{
    public string timeStamp { get; private set; }
    public int totalBeveragesBottles { get; private set; }
    public int totalAlchoolBottles { get; private set; }
    public int beveragesSellToday { get; private set; }
    public int alchoolSellTaday { get; private set; }
    public int remainedBeverageStockNow { get; private set; }
    public int remainedAlchoolBottlesNow { get; private set; }










    public Stock()
	{

    }
    public string GetTimeStamp()
    {
        return this.timeStamp = Convert.ToString(DateTime.Now);
    }

}
