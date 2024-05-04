using System.Net;

namespace PCCO104L.Encapsulation.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aso for sale:");
            Console.WriteLine("");

            Aso husky = new Aso(25.00, "Husky", "Male");
            husky.pangalan = "Allen";
            husky.presyo = 15000.50;
            husky.puro = "Pure Breed";
            husky.nabili = "Sold!";
            husky.Tahol();
            husky.Nabenta();

            Aso GR = new Aso(20.00, "Golden Retriever", "Female");
            GR.pangalan = "Cecillia";
            GR.presyo = 50.5;
            GR.puro = "Mixed Breed";
            GR.nabili = "Reserved.";
            GR.Tahol();
            GR.Nabenta();

            Aso corgi = new Aso(15.00, "Corgi", "Male");
            corgi.pangalan = "Cyrus";
            corgi.presyo = 75000000.99;
            corgi.puro = "Pure Breed";
            corgi.nabili = "Sale!";
            corgi.Tahol();
            corgi.Nabenta();
            corgi.Marco();

        }
    }
}

public class Aso
{
    private string _Lahi { get; set; }

    private double _Bigat { get; set; }

    private string _Kasarian { get; set; }

    public string pangalan { get; set; } 

    public double presyo { get; set; } 

    public string puro { get; set; } 

    public string nabili { get; set; }

    public Aso() { }

    public Aso (double bigat) 
    {

        _Bigat = bigat;
    }

   public Aso(double bigat, string lahi, string kasarian): this (bigat)
    {
        _Lahi = lahi;
        _Kasarian = kasarian;
    }


    public void Tahol()
    {
        Console.WriteLine($"{_Lahi} - {_Bigat} - {_Kasarian} - Name: {pangalan} - {puro} - Tahol!");
        Console.WriteLine($"Selling price: {presyo} pesos");
    }

    public void Nabenta()
    {
        Console.WriteLine($"Status: {nabili}");
        Console.WriteLine("");
    }

    public void Marco()
    {
        Console.WriteLine($"We have more available dogs at our site! Visit www.MarcosDoggyHouse.com.ph");
    }
}