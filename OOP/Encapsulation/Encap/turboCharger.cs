namespace Encap;

public class turboCharger
{
    //Sınıfın iç detaylarını gizleyerek, dışarıya yalnızca gerekli olan kısımları açma prensibi.
    //Bu yüzden genellikle Field da Acces Modifier olarak private kullanılır. Property de public sınıfın
    //dışından erişilebilir olduğunu belirtir.
    private string turbine; //Field

    private double psi;
    private int boost;
    public string Turbine
    {
        get {return turbine;}//metod
        //Get: Name özelliği okunduğunda 'name' field (alanının) değerini döndürür.
        set {turbine = value;}//metod
        //Set: Name alanına değer atar. 'value' kelimesi 'set' metoduna atanmış olan değeri temsil eder.
    }
    public double Psi
    { get {return psi;}//method
      set {psi = value;} //method //default value olarak kullanır.
    }
    public int Boost
    {
        get {return boost;}
        set {boost = value;} //default value olarak kullanır.
    }
    public void Introduce()
    {
        Console.WriteLine($"This TurboCharger have {psi} psi power & {boost} is have power.");
    }

}
