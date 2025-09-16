int[] sayilar = { 5, 10, 15, 20, 25 };
var sonuc = sayilar.Where(s => s > 10).OrderByDescending(s => s).Select(s => s);

foreach(var item in sonuc)
{
    Console.WriteLine(item);
}

string[] isimler = { "Burak", "Ahmet", "Ayşe", "Mehmet" };
var aIsimleri = isimler.Where(i => i.StartsWith("A"));
foreach(var isim in aIsimleri)
{
    Console.WriteLine(isim);
}
//Soru
List<int> numbers = new List<int>() { 1,2,3,4, 5, 6, 7, 9, 11, 13, 15 };
var tekSayilar = numbers.Where(n => n % 2 != 0);
foreach(var num in tekSayilar)
{
    Console.WriteLine(num);
}
//numbers listesinde 5 den büyük sayılar
var bestenBuyuk = numbers.Where(n => n > 5);
foreach(var bes in bestenBuyuk)
{
    Console.WriteLine(bes);
}
//10 dan küçük tek sayilar
var kucukOn = numbers.Where(n => n < 10 && n % 2 != 0);
foreach(var nm in kucukOn)
{
    Console.WriteLine(nm);
}
//çift sayilari al büyükten küçüğe sırala
var ciftSayilar = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n);
foreach(var cft in ciftSayilar)
{
    Console.WriteLine(cft);
}