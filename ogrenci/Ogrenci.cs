using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci
{
    public class Ogrenci
    {
        public ArrayList numara = new ArrayList();
        public ArrayList ad = new ArrayList();
        public ArrayList soyad = new ArrayList();
        public ArrayList not = new ArrayList();

        public void ogrenciEkle()
        {
            Console.WriteLine("Öğrenci numarasını giriniz: ");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("Öğrencinin adını giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Öğrencinin soyadını giriniz: ");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Öğrencinin notunu giriniz: ");
            int puan = int.Parse(Console.ReadLine());

            numara.Add(no);
            ad.Add(isim);
            soyad.Add(soyisim);
            not.Add(puan);
        }

        public void ogrenciSil()
        {
            Console.WriteLine("Silmek istediğiniz öğrenci sırası:");

            int ogrenciSirasi = int.Parse(Console.ReadLine());

            numara.RemoveAt(ogrenciSirasi - 1);
            ad.RemoveAt(ogrenciSirasi - 1);
            soyad.RemoveAt(ogrenciSirasi - 1);
            not.RemoveAt(ogrenciSirasi - 1);


        }

        public void ogrencileriListele()
        {
            for (int i = 0; i < numara.Count; i++)
            {
                Console.WriteLine((i + 1) + ". öğrencinin numarası: " + numara[i]);
                Console.WriteLine((i + 1) + ". öğrencinin adı: " + ad[i]);
                Console.WriteLine((i + 1) + ". öğrencinin soyadı: " + soyad[i]);
                Console.WriteLine((i + 1) + ". öğrencinin puanı: " + not[i]);
                Console.WriteLine("---------------------------------");
            }
        }

        public void sayiGoster()
        {
            Console.WriteLine("Öğrenci Sayısı: " + numara.Count);
        }

        public void ortalamaHesapla()
        {
            int toplam = 0;
            int ortalama;

            for (int i = 0; i < not.Count; i++)
            {
                toplam += (int)not[i];
            }
            ortalama = toplam / not.Count;

            Console.WriteLine("Öğrencilerin not ortalaması: " + ortalama);
        }

        public void cikis()
        {
            Console.WriteLine("İyi Günler :)");
        }
    }
}
