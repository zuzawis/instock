using System.Collections.Generic;
using InStock.Database;

public class PowiadomieniaDTO
{
    public string Tytul { get; set; }
    public string Opis { get; set; }
    public PowiadomieniaDTO(Powiadomienie powiadomienie)
    {
        this.Tytul = powiadomienie.Tytul;
        this.Opis = powiadomienie.Opis;
    }
}
