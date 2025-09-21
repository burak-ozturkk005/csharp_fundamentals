//BOXING UNBOXING
//kutulama (boxing)
//Bir deger tipini, object veya interface türünde referans tipine dönüştürme işlemidir.

int i = 56;
object o = i;

//kutudan çıkarma - unboxing
//Daha önce box edilen bir değeri tekrar kendi değer tipine çıkartma işlemidir.
//cast kullanılır.
i *= 2;
i = (int)o;
Console.WriteLine("Deger turu: {0}",i); //56
Console.WriteLine("Referans turu: {0}",o); //56