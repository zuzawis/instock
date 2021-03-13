using System.Collections.Generic;
using InStock.Database;
public class Sprzedawanie
{
    public int StanSklepuId { get; set; }
    public int RozmiarXS { get; set; }
    public int RozmiarS { get; set; }
    public int RozmiarM { get; set; }
    public int RozmiarL { get; set; }
    public int RozmiarXL { get; set; }
    public int Ilosc { get; set; }

    public List<string> PokazRozmiary(StanSklepu stanSklepu)
    {
        var List = new List<string>();

        if (this.Ilosc > stanSklepu.RozmiarXS)
        {
            List.Add("Za duzo sztuk XS");
        }
        if (this.Ilosc > stanSklepu.RozmiarS)
        {
            List.Add("Za duzo sztuk S");
        }
        if (this.Ilosc > stanSklepu.RozmiarM)
        {
            List.Add("Za duzo sztuk M");
        }
        if (this.Ilosc > stanSklepu.RozmiarL)
        {
            List.Add("Za duzo sztuk L");
        }
        if (this.Ilosc > stanSklepu.RozmiarXL)
        {
            List.Add("Za duzo sztuk XL");
        }
        return List;
    }
}
