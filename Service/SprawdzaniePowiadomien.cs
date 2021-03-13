using InStock.Database;
using System;
using System.Linq;
using InStock.Models;

public class SprawdzaniePowiadomien
{
    private InStockDatabase database { get; set; }
    private ManagerPowiadomien managerPowiadomien;
    public SprawdzaniePowiadomien(InStockDatabase db, ManagerPowiadomien managerPowiadomien)
    {
        this.database = db;
        this.managerPowiadomien = managerPowiadomien;
    }

    public void CzyBrakuje(int produktId, Rozmiar typRozmiaru)
    {
        var produkt = this.database.Produkty.FirstOrDefault(x => x.ProduktId.Equals(produktId));
        if (produkt == null)
        {
            return;
        }

        switch (typRozmiaru)
        {
            case Rozmiar.XS:
                if (produkt.RozmiarXS <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktu("XS", produkt.Kod, produkt.Nazwa);
                }
                break;
            case Rozmiar.S:
                if (produkt.RozmiarS <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktu("S", produkt.Kod, produkt.Nazwa);
                }
                break;
            case Rozmiar.M:
                if (produkt.RozmiarM <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktu("M", produkt.Kod, produkt.Nazwa);
                }
                break;
            case Rozmiar.L:
                if (produkt.RozmiarL <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktu("L", produkt.Kod, produkt.Nazwa);
                }
                break;
            case Rozmiar.XL:
                if (produkt.RozmiarXL <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktu("XL", produkt.Kod, produkt.Nazwa);
                }
                break;
        }
    }
    public enum Rozmiar { XS, S, M, L, XL }

    public void CzyBrakujeNaSklepie(int produktId, Rozmiar typRozmiaru)
    {
        var produktnasklepie = this.database.StanSklepu.FirstOrDefault(x => x.ProduktId.Equals(produktId));
        if (produktnasklepie == null)
        {
            return;
        }

        switch (typRozmiaru)
        {
            case Rozmiar.XS:
                if (produktnasklepie.RozmiarXS <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktuNaSklepie("XS", produktnasklepie.Produkt.Kod, produktnasklepie.Produkt.Nazwa);
                }
                break;
            case Rozmiar.S:
                if (produktnasklepie.RozmiarS <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktuNaSklepie("S", produktnasklepie.Produkt.Kod, produktnasklepie.Produkt.Nazwa);
                }
                break;
            case Rozmiar.M:
                if (produktnasklepie.RozmiarM <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktuNaSklepie("M", produktnasklepie.Produkt.Kod, produktnasklepie.Produkt.Nazwa);
                }
                break;
            case Rozmiar.L:
                if (produktnasklepie.RozmiarL <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktuNaSklepie("L", produktnasklepie.Produkt.Kod, produktnasklepie.Produkt.Nazwa);
                }
                break;
            case Rozmiar.XL:
                if (produktnasklepie.RozmiarXL <= 0)
                {
                    managerPowiadomien.DodajPowiadomienieBrakuProduktuNaSklepie("XL", produktnasklepie.Produkt.Kod, produktnasklepie.Produkt.Nazwa);
                }
                break;
        }
    }

    public void JakSieSprzedaje(int produktId)
    {
        var produkt = this.database.Produkty.FirstOrDefault(x => x.ProduktId.Equals(produktId));
        var sprzedazProduktu = this.database.Sprzedaz.Where(pojedynczaSprzedaz => pojedynczaSprzedaz.ProduktId.Equals(produktId)).ToList();
        var obiektSprzedazyDziennej = new SprzedazDzienna();
        var wysokasprzedaz = obiektSprzedazyDziennej.SprawdzSprzedazDzienna(sprzedazProduktu).FirstOrDefault(x => x.ProduktId.Equals(produktId));
        if (wysokasprzedaz != null)
        {
            if (wysokasprzedaz.Ilosc >= 5){
                managerPowiadomien.DodajPowiadomienieOWysokiejSprzedazy(produkt.Kod, produkt.Nazwa);
            }
        }
    }


}