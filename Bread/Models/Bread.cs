namespace Bakery.Models
{
public class Bread
  {
    public int BreadQuantity { get; }
    public int BreadPrice { get; }
    public Bread(int breadQuantity, int breadPrice)
    {
      BreadQuantity = breadQuantity;
      BreadPrice = 5;
    }

    public int GetBreadCost()
    {
      if (BreadQuantity >= 0)
      {
        int remainderNoDeal = (BreadQuantity % 3);
        int numberOfDeals = (BreadQuantity - (BreadQuantity % 3))/3;
        int dealLoaves = ((BreadQuantity - remainderNoDeal) - numberOfDeals);
        return (dealLoaves + remainderNoDeal) * BreadPrice;
      }
      else
      {
      return 0;
      }
    }
  }
}


/*

Need a bread object to store name and price
need a GetPrice method

Need to use modulo
 - (if numberOfLoaves divisible by 3) then ()

numberOfLoaves = 8
Cost = $30
Singles: 2
3Deal: 6

numberOfLoaves = 7
Cost = $25
Singles: 1
3Deal: 6

remainder = numberOfLoaves % 3

remainderLoaves = (numberOfLoaves - remainder)
loavesDiv3 = remainderLoaves/3
dealLoaves = remainderloaves - loavesDiv3
dealloaves * $5
+
remainder * $5
= loavesCost

remainder = 8 loaves % 3
remainder = 2

(8 - 2) = 6

numberOfLoaves = 8
remainder = 2
remainderLoaves = 6 = (8 - 2)
loavesDiv3 = 2 = 6/3
dealLoaves = 4 = 6 - 2
4 * $5 = $20
+
remainder2 * $5 = $10
$30 = loavesCost

*/
