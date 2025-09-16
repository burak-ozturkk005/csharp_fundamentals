//condition ? deger_if_dogruysa : deger_if_yanlışsa

using System.Collections.Specialized;

int yas = 35;
string sonuc = (yas >= 18) ? "Reşit" : "Reşit değil";
Console.WriteLine(sonuc);
//İç içe
int not = 85;
String derece = (not >= 90) ? "Pekiyi" : (not >= 70) ? "iyi" : (not >= 50) ? "Orta" : "Kaldı";
Console.WriteLine(derece);
//Not: Fazla kullanılırsa kod okunabilirliğini azaltır. Onun için kısa işlemlerde kullanılmas faydalıdır.
