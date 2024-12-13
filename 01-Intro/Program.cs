// LINQ Bİr sorgu dilidir

// Anonim Tipler (Temp = Gecici) = Geçici veri yapılarını oluşturmak için kullanılan bir yapıdır. new{} ile olusturulur.

// x.Take(); İlk istedigimiz kadari alir
// x.Skip(); Sonrasını alır
// orderby desc, asc
// lenght kullanımı = .lenght ascending ile uzunlugu kısa olandan uzun olana sıralar
//                    .lenght descending ile uzunlugu en uzundan kısa olana sıralar.

#region 3'ten buyuk sayilar
//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//var sayiListem = from sL in sayilar // Baglanti yolu
//                 where sL > 3       // kosul yazdigimiz yer
//                 select sL;         // Degerleri yazdigimiz yer

//Console.WriteLine("3'ten  buyuk sayilar");

//foreach (var item in sayiListem)
//{
//    Console.WriteLine(item);
//} 
#endregion

#region Iki sayinin karsilastirilmasi

//int[] sayilar = { 1, 3, 5, 7, 9 };

//int[] sayilar2 = { 1, 5, 8, 7, 22 };

//var kiyasla = from bir in sayilar
//              from iki in sayilar2
//              where bir < iki
//              select new { bir, iki };   // Anonim tipe veri at 

//// Anonim tipler temp gibi davranır (temp = gecici)

//foreach (var x in kiyasla)
//{
//    Console.WriteLine($"Sonuc = {x.bir} < {x.iki}");
//}
#endregion

#region Sayi arttirma islemi

//int[] sayilar = { 2, 1, 4, 6, 12, 86, 89, 0 };

//var sayiArttir = from sayi in sayilar
//                 select sayi + 5;

//Console.WriteLine("Sayi arttirma");

//// Verileri ara ve ekrana yazdir.

//foreach (var degerler in sayiArttir)
//{
//    Console.WriteLine(degerler);
//}
#endregion

#region Upper - Lower

//string[] stringler = { "elma", "eda", "armut", "araba" };

//var yazilar = from n in stringler
//              select new { buyuk = n.ToUpper(), kucuk = n.ToLower() };

//foreach (var x in yazilar)
//{
//    Console.WriteLine($"Buyuk degerler {x.buyuk}, Kucuk degerler {x.kucuk}");
//}
#endregion

#region Take Methodu

//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };

//var ilkDortSayi = sayilar.Take(4);  // atama islemi

//Console.WriteLine("İlk Dort sayi");

//foreach (var deger in ilkDortSayi) // atama islemi yapilan ismin icinde arama yapar
//{
//    Console.WriteLine(deger);
//}
#endregion

#region Skip Method

//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };

//var ilkUcGec = sayilar.Skip(5); // 5'ten sonrasını gosterir.

//foreach (var i in ilkUcGec)
//{
//    Console.WriteLine(i);
//}
#endregion

#region OrderBy a->z sıralaması

//// ascending = alfabetik sıralama 
//// descending = tersten sıralama

//string[] meyveler = { "elma", "armut", "muz", "karpuz", "kavun", "kivi", "ananas" };

//var meyveListesi = from meyve in meyveler // veri kaynagı
//                   orderby meyve descending // listele
//                   select meyve; // cekecegim degerler
//foreach (var item in meyveListesi)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Lenght kullanimi

//string[] sehirler = { "istanbul", "ankara", "izmir", "afyon", "bursa" };

//var sehirlerUzunluk = from sehir in sehirler
//                      orderby sehir.Length 
//                      select sehir;
//foreach (var item in sehirlerUzunluk)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Distic Kullanimi

// cok olan degerlerin sadece bir tanesini getirir.

//int[] kaynaklar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,10,3,4,5,6,7,8,9 }; // birden fazla deger varsa sadece bir tanesini gosterir.

//var kaynak = kaynaklar.Distinct();

//foreach (var k in kaynak)
//{
//    Console.WriteLine(k);
//}
#endregion

#region Union kullanimi

// birlestirme komutudur
// iki diziyi tek bir dizi gibi karsima getirdi ve birden fazla deger varsa sadece bir tanesini aldı.

//int[] sayilar = { 1, 2, 3, 4, 5,5, };
//int[] sayilar2 = { 6, 7, 8, 9, 10 };
//int[] sayilar3 = { 11, 12, 13, 14, 15 };

//var birlestir = sayilar.Union(sayilar2).Union(sayilar3);

//Console.WriteLine(birlestir);

//foreach (var item in birlestir)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Intersect

// Kesisen degerleri gosterir

//int[] sayilar = { 1, 2, 3, 4, 5, 5, };
//int[] sayilar2 = { 3, 4, 5, 6, 7, 8, 9, 10 };

//var kesisenler = sayilar.Intersect(sayilar2);

//// her iki dizide ayni olan degerleri bana gosterir
//foreach (int i in kesisenler)
//{
//    Console.WriteLine(i);
//}
#endregion

#region Except Kullanımı

// dısında komutudur

//int[] sayilar = { 1, 2, 3, 4, 5, 5, };
//int[] sayilar2 = { 3, 4, 5, 6, 7, 8, 9, 10 };

//var disinda = sayilar2.Except(sayilar); // sayilar dizisinde olmayanları bana getirir.
//foreach (int i in disinda)
//    Console.WriteLine(i);
#endregion

#region OfType kullanımı

// belli bir tip degerleri getirir

//object[] degerler = { "elma","iki", 2.3, null };

//var turler = degerler.OfType<string>(); // hangi turen degerler gelsin ?

//foreach (var item in turler)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Range

//var sayilar = from s in Enumerable.Range(1, 50)
//              select new { sayi = s, teksayi = s % 2 == 1 ? "tek" : "cift" };

//foreach (var sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}
#endregion

#region Bool Type Kullanimi 

//int[] sayilar = { 2, 4, 6, 8, 12, 14, 16, 22, 44 };

//bool sadeceCift = sayilar.All(x => x % 2 == 0); // cift sayi olanlar 

//// eger bu dizimin icindeki tum elemanlar cift ise true deger dondurur.

//Console.WriteLine(sadeceCift);
#endregion

#region Contains

//string[] arama = { "eda", "bugun", "derse", "online", "katılacakmıs" };

//bool varmi = arama.Any(ara => ara.Contains("eda"));

//Console.WriteLine(varmi);
#endregion

#region Count

// count = saymak

//int[] sayilar = { 1, 2, 3, 4, 5, 5, 5, 6, 6, 6, 7 };

//var kacsayi = sayilar.Distinct().Count(); // aynı deger olanların bir tanesini gosterip dizinin toplamini gosteriyo

//Console.WriteLine(kacsayi);
#endregion

#region Sum

//int[] sayilar2 = { 3, 4, 5, 6, 7, 8, 9, 10 };

//double toplam = sayilar2.Sum(); // sayilarimi topla

//Console.WriteLine(toplam);
#endregion

#region Min-Max kullanımı

//int[] sayilar2 = { 3, 4, 5, 6, 7, 8, 9, 10 };

//var mindeger = sayilar2.Min();
//var maxdeger = sayilar2.Max();
//Console.WriteLine(mindeger);
//Console.WriteLine(maxdeger);
#endregion

#region Min-Max Lenght

//string[] meyveler = { "elma", "armut", "muz" };

//var kısaString = meyveler.Min(min => min.Length);
//var uzunString = meyveler.Max(max => max.Length);

//Console.WriteLine(kısaString);
//Console.WriteLine(uzunString);
#endregion

#region Average kullanımı

// ort hesaplama

//int[] sayilar2 = { 3, 4, 5, 6, 7, 8, 9, 10 };

//double ortalama = sayilar2.Average();
//Console.WriteLine(ortalama);
#endregion

#region Concat

//int[] sayilar = { 1, 2, 3, 4, 5, 5, };
//int[] sayilar2 = { 6, 7, 8, 9, 10 };

//var sayilarim = sayilar.Concat(sayilar2); // sayilar1 in sonuna sayilar2 listesini ekler.

//foreach (int i in sayilarim)
//{
//    Console.WriteLine(i);
//}
#endregion

#region Sequence Equal

// iki listenin birbirine esit olup olmadıgını kontrol eder.

//int[] sayilar = { 1, 2, 3, 4, 5, 5, };
//int[] sayilar2 = { 6, 7, 8, 9, 10 };

//bool esitMi = sayilar.SequenceEqual(sayilar2);
//Console.WriteLine(esitMi);
#endregion



