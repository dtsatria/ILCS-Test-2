// See https://aka.ms/new-console-template for more information
using System;

namespace TestClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Negara           : ");
            string inputNegara = Console.ReadLine();
            Console.Write("Pelabuhan        : ");
            string inputPelabuhan = Console.ReadLine();
            Console.Write("Barang           : ");
            string inputBarang = Console.ReadLine();
            Console.Write("Harga Barang     : ");
            double inputHargaBarang = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------Tarif Bea-----------");

            Shipping s = new Shipping(inputNegara, inputPelabuhan, inputBarang, inputHargaBarang);

            Console.WriteLine($"Negara      : {s.Negara}");
            Console.WriteLine($"Pelabuhan   : {s.Pelabuhan}");
            Console.WriteLine($"Barang      : {s.Barang}");
            Console.WriteLine($"Harga       : {s.Harga}");
            Console.WriteLine($"Tarif Bea   : {s.TarifBeaCount(s.Harga)}");

        }
    }
}

