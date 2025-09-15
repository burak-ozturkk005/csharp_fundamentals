//Kapasite
using System.Text;

StringBuilder sb = new StringBuilder(50); // Başlangıç kapasitesi 50
sb.Append("Merhaba");
Console.WriteLine(sb.Length); // 7
//İkisi farklı şeyler
sb.Insert(0, "Selam "); //Başa ekler
sb.Replace("Selam", "Burak"); //değiştirme
sb.Remove(0, 6); // ilk 6 karakteri siler
sb.Clear(); // Tamamen sıfırlar.
//Karakterlere erişim  normal  arraylerde olduğu gibidir.
StringBuilder sbc = new StringBuilder("TEst");
Console.WriteLine(sbc[0]);
sbc[0] = 'B';
Console.WriteLine(sbc);
//Gorev 2 Çarpım Tablosu
StringBuilder carpimTablosu = new StringBuilder();
for(int i = 1; i <= 10; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        carpimTablosu.Append($" {i} x {j} = {i * j}");
        if(j < 10)
        {
            carpimTablosu.Append(" | ");
        }
    }
    carpimTablosu.AppendLine(); //satır sonu alt satıra geç
}
Console.WriteLine(carpimTablosu.ToString());