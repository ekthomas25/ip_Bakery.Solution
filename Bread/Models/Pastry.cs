
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
      if (PastryQty > 2)
      {
      return (((PastryQty - (PastryQty % 3))/3)*5) + ((PastryQty % 3) * PastryPrice);
      }
      else
      {
        return PastryQty*PastryPrice;
      }
    }
  }
}

/*
  Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.

Essentially: Buy 2 get one half off

(5 - 2)+ (2* 2)
3 + 4 = 7

PastryQty = 1
Cost = 2
Singles: 1


PastryQty = 3
Cost = $5
NoDeal = 0
Deal = 3

PastryQty = 4
Cost = 7
NoDeal = 1
Deal = 3

Deal = (PastryQty - (Pastryqty % 3)) * 5
NoDeal = (pastryQty % 3) * 2

3 - 0 /3 = 1 * 5 = 5
0* PastryPrice = 0

PastryQty = 5
Cost = $9
NoDeal = 2  
Deal = 3

5 - 2 = 3/3 = 1 * 5 = 5
2 * PastryPrice = 4
Total = 9

PastryQty = 6
Cost = $10
NoDeal = 0 
Deal = 6



*/
