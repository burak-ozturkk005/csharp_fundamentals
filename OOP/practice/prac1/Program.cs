using prac1;

Hayvan[] hayvanlar = new Hayvan[]
{
    new Kedi {Ad = "Tekir"},
    new Kopek {Ad = "Karabaş"}
};
foreach(var h in hayvanlar)
{
    h.SesCikar();
}