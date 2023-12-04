using System;

namespace TestClasses
{
    class Shipping
    {

        public string Negara
        { get; set; }
        public string Pelabuhan
        { get; set; }
        public string Barang
        { get; set; }
        public double Harga
        { get; set; }
        public double TarifBea
        { get; set; }

        public Shipping(string negara, string pelabuhan, string barang, double harga)
        {
            Negara = negara;
            Pelabuhan = pelabuhan;
            Barang = barang;
            Harga = harga;
        }
        public double TarifBeaCount(double harga)
        {
            Harga = harga;
            return TarifBea = Harga * (10 / 100.0);
        }
    }


}

