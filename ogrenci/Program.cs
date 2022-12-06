using ogrenci;
using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Ogrenci ogr = new Ogrenci();

        Console.WriteLine("Programa Hoş Geldiniz :)\n");
        while (true)
        {

            Console.WriteLine("İşlemler");
            Console.WriteLine("====================");
            Console.WriteLine("1- öğrenci ekle");
            Console.WriteLine("2- öğrenci sil");
            Console.WriteLine("3- tüm öğrencileri listele");
            Console.WriteLine("4- kayıtlı öğrenci sayısını göster");
            Console.WriteLine("5- genel not ortalamasını hesapla");
            Console.WriteLine("0- çıkış\n");
            Console.WriteLine("Seçiminiz:");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 0: ogr.cikis(); break;
                case 1: ogr.ogrenciEkle(); break;
                case 2: ogr.ogrenciSil(); break;
                case 3: ogr.ogrencileriListele(); break;
                case 4: ogr.sayiGoster(); break;
                case 5: ogr.ortalamaHesapla(); break;
                default: Console.WriteLine("Geçerli seçim yapınız"); break;

            }

            if (secim == 0)
            {
                break;
            }

        }




        Console.ReadKey();
    }
}
