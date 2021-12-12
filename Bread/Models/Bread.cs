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