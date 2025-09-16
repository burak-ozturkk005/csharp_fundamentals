//Belirli bir şart sağlandığında çalışan 
/*if(condition)
{
    kod
}
else {
ilk koşul yanlışsa burası çalışır
  kod
}
*/
//Örn
int yas = 25;
if(yas > 22)
{
    Console.WriteLine("C ehliyeti alabilir.");
}
else
{
    Console.WriteLine("Ehliyeti alamaz.");
}
//Ternary if
int sayi = 15;
string sonuc = (sayi % 2 == 0) ? "Çift" : "Tek";
Console.WriteLine(sonuc);