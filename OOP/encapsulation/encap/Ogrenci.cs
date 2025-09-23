using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    internal class Ogrenci
    {
        private int not;
        public string Ad { get; set; }
        public int Not { get { return not; } 
                         private set
                         {
                if (value >= 0 && value <= 100)
                    not = value;
                else
                    Console.WriteLine("Hatalı Not! 0-100 arasında değer girin.");
                          }
            }
        public void NotGetir()
        {
            Console.WriteLine($"{Ad} isimli öğrencinin notu: {Not}");
        }
        public void NotGuncelle(int yeniNot)
        {
            if (yeniNot >= 0 && yeniNot <= 100)
                Not = yeniNot;
            else
                Console.WriteLine("Geçersiz not girdiniz!");
        }
    }
}
