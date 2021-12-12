
namespace Bakery.Models
{
 public class Pastry
  {
   public int PastryQty { get; }
    public int PastryPrice { get; }
    public Pastry(int pastryQty, int pastryPrice)
    {
      PastryQty = pastryQty;
      PastryPrice = 2;
    }

    public int GetPastryCost()
    {
      return PastryQty*PastryPrice;
    }
  }
}

/*
  Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.

Essentially: Buy 3 get one half off

PastryQty = 1
PastryPrice = 2

PastryQty = 3
PastryPrice = 5

*/
