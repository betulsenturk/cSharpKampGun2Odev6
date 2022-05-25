using System;

namespace Gun2Odev6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Urun urun1 = new Urun("Çikolata", 3.25, 124);
            Urun urun2 = new Urun("Kraker", 2, 76);
            Urun urun3 = new Urun("Cips", 7.85, 83);
            Urun urun4 = new Urun("Çekirdek", 4.5, 90);

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("***For dongusu ile yazdırıldı***");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ToString());
            }

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("***Foreach dongusu ile yazdırıldı***");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.ToString());
            }

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("***While dongusu ile yazdırıldı***");
            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].ToString());
                j++;
            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public int StokAdet { get; set; }

        public Urun(string UrunAdi, double UrunFiyati, int StokAdet)
        {
            this.UrunAdi = UrunAdi;
            this.UrunFiyati = UrunFiyati;
            this.StokAdet = StokAdet;
        }

        public String ToString()
        {
            return "Ürün adı: " + UrunAdi + "\nÜrün Fiyatı: " + UrunFiyati + "\nStok Adedi: " + StokAdet + "\n";
        }

    }
}
