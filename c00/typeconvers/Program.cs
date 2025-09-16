//KApali (implicit) Dönüşüm
int sayi = 100;
long uzunSAyi = sayi; // int to long donusumu (kapali dönüşüm)
//(Explicit) açık dönüşüm
double num = 3.86;
int tamsayi = (int)num; // double to int veri kaybı
Console.WriteLine(tamsayi); // ondalık kısım gitti..
//Convert sınıfı
string strSayi = "12345";
int intsayi = Convert.ToInt32(strSayi); // string to int donusumu
double dblSayi = Convert.ToDouble(strSayi); // string to double donusumu
//Parse ve TryParse Metodları
//Parse yalnızca string ifadeleri belirli veri tiplerine çevirmek için kullanılır.
string strNumber = "456";
int number = int.Parse(strNumber); // string to int donusumu
//TryParse BAŞARISIZ OLURSA HATA FIRLATMAZ.
string astr = "bmw";
int numbera;
bool basarili = int.TryParse(astr, out number);

if (basarili)
    Console.WriteLine("Donusum başarili: " + number);
else
    Console.WriteLine("Donusum basarisiz!");
