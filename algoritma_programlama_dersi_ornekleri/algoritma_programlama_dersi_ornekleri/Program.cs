using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma_programlama_dersi_ornekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int buyuk = Karsilastir(3, 5);
            //Console.WriteLine(buyuk);
            //var x = KareAl(3);
            //double y = KareAl(x);
            //Console.WriteLine(x);
            //Console.WriteLine(y);




            //int x = 10;
            //int y = 20;
            //Console.WriteLine("{0},{1}",x,y);
            //Degistir(ref x,ref y);
            //Console.WriteLine("{0},{1}", x, y);




            //OgretimElemani ogrGor = new OgretimElemani(100, "Ahmet", "Yalçın", true); //Tanımlama
            /*
             {
                SicilNo=102,
                Adi="Ahmet",
                Soyadi="Yalçın",
                Cinsiyet=true
             }
            //Atama
            ogrGor.SicilNo=101;
            ogrGor.Adi="Ahmet";
            ogrGor.Soyadi="Yalçın";
            ogrGor.Cinsiyet=true;
             */
            //Console.WriteLine(ogrGor);

            //var liste1 = new List<OgretimElemani>() //Tanımlama-Atama
            //{
            //    new OgretimElemani(100,"Ahmet","Yalçın",true),
            //    new OgretimElemani(101,"Aylin","Dag",false),
            //    new OgretimElemani(102,"Mehmet","Yıldız",true),
            //    new OgretimElemani(103,"Servet","Aydogdu",true),
            //    new OgretimElemani(104,"Leyla","Aydın",false),
            //    new OgretimElemani(105,"Selim","Aslıhan",true)
            //};
            //liste1.RemoveAt(0);
            //Console.WriteLine(liste1);
            //liste1.ForEach(ogr => Console.WriteLine(ogr));
            //Console.WriteLine();




            //Array Classlar
            //int[] sayilar = new int[] { 5, 3, 8, 10, 2, 18, 23, 44, 55, 6, 34, 19 }; //Array | Dizi | Tanımlama
            //var numbers=Array.CreateInstance(typeof(int), sayilar.Length);
            //var arr = new ArrayList(sayilar);
            //sayilar.CopyTo(numbers, 0);
            //Array.Sort(sayilar);
            //Array.Sort(numbers);
            //Array.Clear(sayilar, 2, 2);
            //Console.WriteLine(Array.IndexOf(sayilar, 55));
            //arr.Sort();
            //for(int i = 0; i < numbers.Length; i++) //Dolaşma
            //{
            //    Console.WriteLine($"sayilar[{i}]= " +
            //        $"{sayilar[i],3} - " +
            //        $"{numbers.GetValue(i),3} " +
            //        $"arr[{i}]) = " +
            //        $"{arr[i],3}");
            //}


            

            Console.ReadKey();
        }
        private static void mutlakDeger() //Operatörler
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"|{n}|={n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}|={n}");
            }
            Console.ReadKey();
        }
        private static void arayListeler() //ArrayListler
        {
            var arrayList = new ArrayList()
            {
                10,"BTK Akademi",true,'e'
            }; //Tanımlama
            foreach (var e in arrayList)
            {
                Console.Write($"{e} "); //Dolaşma
            }
            int[] sayilar = new int[] { 23, 44, 55 }; //Dolaşma
            arrayList.AddRange(sayilar);
            Console.WriteLine();
            foreach (var e in arrayList)
            {
                Console.Write($"{e} "); //Dolaşma
            }
            Console.WriteLine();
            Console.WriteLine(arrayList[4]); //Elemana erişme
            var x = (int)arrayList[0];
            Console.WriteLine(x + 10); //Elemana erişme ve atama
            arrayList.Remove(10); //Eleman silme
            arrayList.RemoveAt(1); //Eleman silme
            Console.WriteLine();
            foreach (var e in arrayList)
            {
                Console.Write($"{e} "); //Dolaşma
            }
            Console.ReadKey();
        }
        public static int Karsilastir(int A, int B) //Metotlar
        {
            if (A > B)
            {
                return A;
            }
            else
            {
                return B;
            }
        }
        static double KareAl(double sayi) //Metotlar
        {
            double kare = sayi * sayi;
            return kare;
        }
        private static void Degistir(ref int a, ref int b) //Referans tipler
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);
        }
        private static void ListeUygulamasi() //Liste ve Referans Tipler
        {
            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Zonguldak",
                "Diyarbakır"
            };
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine(new string('-', 50));
            sehirler.Add("Bursa");
            Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
            sehirler.Remove("Ankara");
            sehirler.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();
        }
        private static void VeriTürleri() //Veri türlerinin alt ve üst limitleri
        {
            //8-bit integer
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit:  {SByte.MinValue,20}");
            Console.WriteLine($"Üst limit:  {SByte.MaxValue,20}");
            Console.WriteLine($"Boyut:      {sizeof(SByte),20}");
            Console.WriteLine();

            //Unsigned 8-bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit:  {Byte.MinValue,20}");
            Console.WriteLine($"Üst limit:  {Byte.MaxValue,20}");
            Console.WriteLine($"Boyut:      {sizeof(Byte),20}");
            Console.WriteLine();

            //Signed 16-bit integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit:  {Int16.MinValue,20}");
            Console.WriteLine($"Üst limit:  {Int16.MaxValue,20}");
            Console.WriteLine($"Boyut:      {sizeof(Int16),20}");
            Console.WriteLine();

            //Unsigned 16-bit integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit:  {UInt16.MinValue,20}");
            Console.WriteLine($"Üst limit:  {UInt16.MaxValue,20}");
            Console.WriteLine($"Boyut:      {sizeof(UInt16),20}");
            Console.WriteLine();

            //Signed 32-bit integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit:  {Int32.MinValue,20}");
            Console.WriteLine($"Üst limit:  {Int32.MaxValue,20}");
            Console.WriteLine($"Boyut:      {sizeof(Int32),20}");
            Console.WriteLine();

            //Double
            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit:  {Double.MinValue,20}");
            Console.WriteLine($"Üst limit:  {Double.MaxValue,20}");
            Console.WriteLine($"Boyut:      {sizeof(Double),20}");
            Console.WriteLine();

        }
        public class OgretimElemani
        {
            //Property-Ozellik
            public int SiciliNo { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public bool Cinsiyet { get; set; }
            public OgretimElemani(int sicilno, string adi, string soyadi, bool cinsiyet)
            {
                SiciliNo = sicilno;
                Adi = adi;
                Soyadi = soyadi;
                Cinsiyet = cinsiyet;
            }
            public override string ToString()
            {
                return $"{SiciliNo,-5} " +
                       $"{Adi,-10} " +
                       $"{Soyadi,-10} " +
                       string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
            }
        } //Classlar
        private static void hastableler() //Hashtable
        {
            var sehirler = new Hashtable(); //Tanımlama
            sehirler.Add(6, "Ankara"); //Ekleme
            sehirler.Add(34, "İstanbul");
            sehirler.Add(35, "Samsun");
            sehirler.Add(23, "Elazığ");
            foreach (DictionaryEntry item in sehirler) //Dolaşma
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"- {item.Value,-20}");
            }
            Console.WriteLine("\nAnahtarlar (Keys)"); //Anahtarları alma
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nDeğerler (Values)"); //Değerler
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nElemana Erişme"); //Elemana erişme
            Console.WriteLine(sehirler[34]);
            Console.WriteLine("\nEleman Silme"); //Eleman silme
            sehirler.Remove(23);
            foreach (DictionaryEntry item in sehirler) //Dolaşma
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"- {item.Value,-20}");
            }
        }
        private static void hastableornek() //Hashtable Ornek
        {
            Console.WriteLine("Başlığı giriniz: "); //Başlığı okuma
            string baslik = Console.ReadLine();
            baslik = baslik.ToLower(); //Başlığı küçültme
            var karakterSeti = new Hashtable() //Hashtable
            {
                { 'ç','c'},
                { 'ı','i'},
                { 'ö','o'},
                { 'ü','u'},
                { ' ','-'},
                { '\'','-'},
                { 'ğ','g'},
                { '.','-'},
                { '?','-'},
                {'ş','s' }
            };
            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }
            Console.WriteLine(baslik); //Ekrana yazdır
        }
        private static void sortedListeler() //SortedList
        {
            var list = new SortedList() //Tanımlama
            {
                {1,"Bir" },
                {2,"İki"},
                {3,"Üç" },
                {8,"Sekiz" },
                {5,"Beş" },
                {6,"Altı" }
            };
            list.Add(4, "Dört");
            var anahtarlar = list.Keys;
            Console.WriteLine("\nAnahtarlar");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }
            var degerler = list.Values;
            Console.WriteLine("\nDeğerler");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nGuncelleme");
            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }
            foreach (DictionaryEntry item in list) //Dolaşma
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Listedeki Eleman Sayısı : {0}", list.Count);
            Console.WriteLine("Listenin Kapasitesi : {0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin Kapasitesi : {0}", list.Capacity);
            Console.WriteLine("\n");
            Console.WriteLine(list[4]); //Erişme | Key
            Console.WriteLine(list.GetByIndex(0)); //Index
            Console.WriteLine(list.GetKey(0)); //Get | Key
            Console.WriteLine(list.GetByIndex(list.Count - 1)); //Liste sonundaki eleman değeri
        }
        private static void sortedOrnek() //SortedList Ornek
        {
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1, "Onsoz");
            kitapIcerigi.Add(50, "Degiskenler");
            kitapIcerigi.Add(40, "Operatorler");
            kitapIcerigi.Add(60, "Donguler");
            kitapIcerigi.Add(45, "Ilıskısel Operatorler");
            Console.WriteLine("Icındekıler");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"{"Konular",-33} {"Sayfalar",8}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,8}");
            }
        }
        private static void stakbir() //Stack Ornek 1
        {
            var karakterYigini = new Stack<char>(); //Stack tanımlama
            karakterYigini.Push('A'); //Ekleme
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı");
        }
        private static void stakiki() //Stack Ornek 2
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi");
                Console.WriteLine($"Yığındaki eleman sayisi: {karakterYigini.Count}");
            }
            Console.WriteLine("Yığındaki çıkartna işlemi için bir tuşa basınız");
            Console.ReadKey();
            Console.WriteLine();
            while (karakterYigini.Count > 0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından çıkartıldı");
                Console.WriteLine($"Yığındaki eleman sayisi: {karakterYigini.Count}");
            }
        }
        private static void stakuc() //Stack Ornek 3
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            var sayiYigini = new Stack<int>();
            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }
            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"{s} x {Math.Pow(10, n - i)}={s * Math.Pow(10, n - i)}");
                i++;
            }
        }
        private static void que() //Queue
        {
            var karakterKuyrugu = new Queue<char>(); //Tanımlama
            karakterKuyrugu.Enqueue('a'); //Ekleme
            karakterKuyrugu.Enqueue('e');
            Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");
            var dizi = karakterKuyrugu.ToArray(); //Diziye atama
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkartıldı");
            Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
        }
        private static void linkedListeler() //LinkedList
        {
            var sehirler = new LinkedList<string>(); //Tanımlama
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddFirst("İstanbul");
            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");
            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            Console.WriteLine();
            var eleman = sehirler.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }
            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();
            var gecici = sehirler.Last;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }
        }
        private static void sozlukler() //Dictionary
        {
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {424,"Elazığ" },
                {466,"Art" }
            };
            telefonKodlari.Add(322, "Adana"); //Ekleme
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");
            telefonKodlari[466] = "Artvin"; //Erişme
            if (telefonKodlari.ContainsKey(312)) //ContainsKey
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanimli değil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi");
            }
            if (telefonKodlari.ContainsValue("Malatya")) //ContainsValue
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanimli değil!");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi");
            }
            telefonKodlari.Remove(322); //Silme İşlemi
            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }
        }
    }
}
