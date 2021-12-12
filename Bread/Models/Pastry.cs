
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
      else if (PastryQty >= 0 && PastryQty < 3)
      {
        return PastryQty*PastryPrice;
      }
      else
      {
        return 0;
      }
    }
  }
}