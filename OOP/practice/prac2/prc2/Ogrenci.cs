using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prc2
{
    internal class Ogrenci
    {
        private int _not;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Not
        {
            get { return _not; }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    _not = value;
                }else
                {
                    Console.WriteLine("Hata: Not 0-100 arasında olmalı!");
                }
            }
        }
        public void NotGoster()
        {
            Console.WriteLine($"{Ad} {Soyad}  ogrencinin notu {_not}");
        }

    }
}
