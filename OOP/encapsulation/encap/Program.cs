//Encapsulation: Bir sınıfın iç detaylarını gizleme, dışarıya sadece kontrollü kapılar
//property,method..
using encap;

var ogr = new Ogrenci { Ad = "Burak" };
ogr.NotGuncelle(96);
ogr.NotGetir();