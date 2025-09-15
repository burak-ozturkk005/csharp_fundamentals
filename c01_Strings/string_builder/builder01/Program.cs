using System;
using System.Text;

//String Builder üzerinde çok fazla ekleme çıkarma değiştirme gibi işlemler yapacağımız zaman kullanılır.
//Normal string immutable dır. Yani her değişiklikte yeni bir string oluşturulur. Bu da performansı düşürür.
//StringBuilder ise mutable dır. Yani tek bir nesne üzerinde oynar, yeni string oluşturulmaz.

string s = "";
for(int i = 0; i< 1000; i++)
{
    s += i; // her adımda yeni string.
}
StringBuilder sb = new StringBuilder();
for(int i = 0; i< 1000; i++)
{
    sb.Append(i); //aynı nesne üzerinden işlem.
}
string result = sb.ToString(); //yeni bir string oluşturduk.
//Görev 1-2-3-4-5 stringbuilder ile oluştur.
StringBuilder sbn = new StringBuilder();
for(int i = 0; i<6;i++)
{
    sbn.Append(i);
    if (i < 5)
    {
        sbn.Append(" - ");
    }
}
Console.WriteLine(sbn.ToString());
//Önceki görevi tersten yap
StringBuilder sbm = new StringBuilder();
for(int i = 5; i >= 0;i--)
{
    sbm.Append(i);
    if(i > 0)
    {
        sbm.Append(" - ");
    }
}
Console.WriteLine(sbm.ToString());