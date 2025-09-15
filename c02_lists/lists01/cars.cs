namespace lists01;

public class cars : Turbo
{
    public string brand;
    public string psi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int numberof { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Brand { get{
        return brand;}} //set burda default olarak atanır. null falan değil. 

    public bool openorclose { get; set; }
}
