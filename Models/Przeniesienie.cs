using System.Collections.Generic;
using InStock.Database;
public class Przeniesienie
{
    public int ProduktId { get; set; }
    public int RozmiarXS { get; set; }
    public int RozmiarS { get; set; }
    public int RozmiarM { get; set; }
    public int RozmiarL { get; set; }
    public int RozmiarXL { get; set; }
    public List<string> PobierzBledy(Produkt produkt)
    {
        var List = new List<string>();
        if (this.RozmiarXS > produkt.RozmiarXS)
        {
            List.Add("Za duzo sztuk XS");
        }
        if (this.RozmiarS > produkt.RozmiarS)
        {
            List.Add("Za duzo sztuk S");
        }
        if (this.RozmiarM > produkt.RozmiarM)
        {
            List.Add("Za duzo sztuk M");
        }
        if (this.RozmiarL > produkt.RozmiarL)
        {
            List.Add("Za duzo sztuk L");
        }
        if (this.RozmiarXL > produkt.RozmiarXL)
        {
            List.Add("Za duzo sztuk XL");
        }
        return List;
    }
}
