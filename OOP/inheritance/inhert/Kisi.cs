using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    internal class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public void KendiniTanit()
        {
            Console.WriteLine($"Ben {Ad} {Soyad} ");
        }
    }
    class Ogrenci : Kisi
    {
        public int Numara { get; set; }
    }
    class Ogretmen : Kisi
    {
        public string Brans { get; set; }
    }
}
