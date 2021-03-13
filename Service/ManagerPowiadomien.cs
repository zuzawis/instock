using InStock.Database;
using System;
using System.Linq;
public class ManagerPowiadomien
{
    private InStockDatabase bazadanych { get; set; }
    public ManagerPowiadomien(InStockDatabase db)
    {
        this.bazadanych = db;
    }

    public void DodajPowiadomienie(string tytul, string opis)
    {
        var dodanePowiadomienie = new Powiadomienie()
        {
            Tytul = tytul,
            Opis = opis,
            CzyPrzyjete = false,
            Data = DateTime.Now,
        };
        this.bazadanych.Powiadomienia.Add(dodanePowiadomienie);
        this.bazadanych.SaveChanges();
    }

    public void DodajPowiadomienieOWysokiejSprzedazy(string kod, string nazwa)
    {
        this.DodajPowiadomienie("Wysoka sprzedaz produktu", $"Wyeksponuj na sklepie produkt o kodzie {kod} i nazwie {nazwa}");
    }

    public void DodajPowiadomienieBrakuProduktu(string rozm, string kod, string nazwa)
    {
        this.DodajPowiadomienie("Brak produktu", $"Domów produkt o kodzie {kod}, nazwie {nazwa} i rozmiarze {rozm}");
    }

    public void DodajPowiadomienieBrakuProduktuNaSklepie(string rozm, string kod, string nazwa)
    {
        this.DodajPowiadomienie("Brak produktu na sklepie", $"Przenieś z magazynu produkt o kodzie {kod}, nazwie {nazwa} i rozmiarze {rozm}");
    }

    public void UsunStarsze ()
    {
        var piecdnitemu = DateTime.Now.Date.AddDays(-5);
        var powiadomienie = this.bazadanych.Powiadomienia.Where(x => x.Data<piecdnitemu).ToList();
        this.bazadanych.Powiadomienia.RemoveRange(powiadomienie);
        this.bazadanych.SaveChanges();
    }

}