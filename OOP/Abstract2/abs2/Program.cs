using abs2;

List<Hayvan> hayvans = new List<Hayvan>
{
    new Kedi {Ad = "Tekir"}
};
foreach ( var h in hayvans)
{
    h.SesCikar();
    h.YemekYe();
}