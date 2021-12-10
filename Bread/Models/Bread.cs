namespace Bakery
{
  public class Bread
  {

  }
}

/*

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
2 * $5 = $10
$30 = loavesCost

*/
