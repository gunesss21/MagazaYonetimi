using System;
using System.Collections.Generic;

// Soyut Urun Sınıfı
abstract class Urun
{
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }

    protected Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    public abstract decimal HesaplaOdeme();

    public abstract void BilgiYazdir();
}

// Kitap Sınıfı
class Kitap : Urun
{
    public string Yazar { get; set; }

    public Kitap(string ad, decimal fiyat, string yazar) : base(ad, fiyat)
    {
        Yazar = yazar;
    }

    public override decimal HesaplaOdeme()
    {
        return Fiyat * 1.10m; // %10 vergi
    }

    public override void BilgiYazdir()
    {
        Console.WriteLine($"Kitap: {Ad}, Yazar: {Yazar}, Fiyat: {Fiyat:C}, Ödenecek: {HesaplaOdeme():C}");
    }
}

// Elektronik Sınıfı
class Elektronik : Urun
{
    public string Marka { get; set; }

    public Elektronik(string ad, decimal fiyat, string marka) : base(ad, fiyat)
    {
        Marka = marka;
    }

    public override decimal HesaplaOdeme()
    {
        return Fiyat * 1.25m; // %25 vergi
    }

    public override void BilgiYazdir()
    {
        Console.WriteLine($"Elektronik: {Ad}, Marka: {Marka}, Fiyat: {Fiyat:C}, Ödenecek: {HesaplaOdeme():C}");
    }
}

// Program
class Program
{
    static void Main(string[] args)
    {
        List<Urun> urunler = new List<Urun>
        {
            new Kitap("Nutuk", 100, "Mustafa Kemal Atatürk"),
            new Elektronik("İphone 16 Pro Max", 121000, "Apple"),
            new Kitap("1984", 40, "George Orwell"),
            new Elektronik("Televizyon", 3000, "Samsung")
        };

        Console.WriteLine("Mağaza Ürün Listesi:");
        Console.WriteLine("--------------------");

        foreach (var urun in urunler)
        {
            urun.BilgiYazdir();
        }
    }
}