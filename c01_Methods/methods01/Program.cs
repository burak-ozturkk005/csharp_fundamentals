
 public class Program{
    // [erisim belirleyici] [geri donus degeri] [Metot adı] (...)
    //{}
    #region Bir metodun geriye deger dondurmesi 
    //
        //Metodun geriye döndürdüğü değer, algoritmaların akışında kullanılabilir değerdir!!!

    #endregion
    static void Main(string[] args){
        //parametrenin değerini metodun  içerisinde herhangi bir yerde çağırıp kullanabiliriz.
        //Metot içerisinde üretilen herhangi bir değeri tutacak değişken oluşturmaktansa parametre üzerinde bu değeri tutabiliriz.
        //Yani parametrenin değerini değiştirebiliriz. (Çünkü parametreler özünde bir değişkendir.)

    }
    #region Parameters
    //In komutu sayesinde parametreye verilen değeri sabit tutabilmekteyiz.
    //In komutu, metodun parametresini readonly(sadece okunabilir) hale getirir.
    #endregion
    static void C(in int a = 678){

    }
    static void MyMethod() //Methodun imzası
    {
        //Static: Statik metotlar, yalnızca statik değişkenleri
        //ve statik üyeleri kullanabilir. Sınıf adı üzerinden çağrılır.
        //void:  geriye değer döndürmeyen metotların imzasında bulunur.
        System.Console.WriteLine();
    }

}