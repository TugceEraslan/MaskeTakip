using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();  // Bi tane vatandaş oluşturdum. Buna instance deniyor

            SelamVer(isim: "Tuğçe");
            SelamVer(isim: "Canan");
            SelamVer(isim: "Fevzi");
            SelamVer();

            int sonuc = Topla(3,5);

            // Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Ahmet";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];  // 3 tane elemanlı ogrenciler dizisi tanımlamış oluyoruz.
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Ahmet";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "İstanbul", "Ankara", "İzmir" };
            string[] sehirler2 = new[] { "Bura", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

           Person person1 = new Person();
           person1.FirstName = "TUĞÇE";
           person1.LastName = "ERASLAN";
           person1.DateOfBirthYear = 1995;
           person1.NationalIdentity = 123456;



           Person person2 = new Person();
           person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)  // foreach ile dizi formatında ki yapıları dönüyoruz
            {
                Console.WriteLine(sehir);  // sehir , sehirler1 dizisini gezerken her bir elemanı gezerken ona verdiğimiz alias ımız oluyor 
            }

            //List<string> yeniSehirler1 = new List<string>();
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" }; // 3 elemanlı bir liste aslında dizi gibidir.
            // List in bir sürü prop özelliği vardır çünkü Liste bir sınıftır
            yeniSehirler1.Add("Adana 1");  // 4 elemanlı

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            // List kullanımına alternatif olarak ArrayList kullandım
            ArrayList myList = new ArrayList() { "Sivas", "Muğla", "Edirne" };
            foreach (var city in myList)
            {
                Console.WriteLine(city);
            }

            myList.Add("Kayseri-2");

            foreach(var city in myList) 
            { 
                Console.WriteLine(city); 
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();




            int sonucDefault = Topla();

            Console.ReadLine();
        }

        // resharper

        // Parametresi olan bir fonksiyonun parametresiz çalışabilmesi için (string isim ="isimsiz") yazarsak default değeri isimsiz gelir 
        static void SelamVer(string isim ="isimsiz")  // void metodu emir kipiyle çalışır bir sonuç döndürmez. Sonuç döndürmesini istiyorsak void kullanmamalıyız.
        {
            Console.WriteLine("Merhaba " + isim);
        }

        //default parametreler en sona yazılır
        static int Topla(int sayi1 = 5, int sayi2 = 10)  // parametre ile gelen ayi1 ve sayi2 yi return de topla demek
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc.ToString());
            return sonuc;
        }



        //private static void Degiskenler()
        //{
        //    string message = "Merhaba";
        //    double tutar = 100000;  // db den gelir
        //    int sayi = 100;
        //    bool girisYapmisMi = false;

        //    string ad = "Tuğçe";
        //    string soyad = "Eraslan";
        //    int dogumYili = 1995;
        //    long tcNo = 12345678910;


        //    Console.WriteLine(tutar * 1.18);
        //    Console.WriteLine(100000 * 1.18);


        //    Console.WriteLine(message);
        //}
    }

    //pascal casing--> Class,Proporty ve Metod isimleri aşıdaki gibi her harfi büyük yazılır
    public class Vatandas  // Class ın içine vatandaşa ait alanları koydum. Yani Vatandas.ad diyince Tuğçe yazacak. Değişkenlerle değil class ın kendisiyle uğraşıyorum
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}

