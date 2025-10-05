using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intres
{
    internal interface IArac
    {
        void Calistir();
        void Durdur();
    }
    public class Araba : IArac
    {
        public void Calistir()
        {
            Console.WriteLine("Araba çalıştı.");
        }
        public void Durdur()
        {
            Console.WriteLine("Araba durdu.");
        }
    }
    public class Motor : IArac
    {
        public void Calistir()
        {
            Console.WriteLine("Motor çalıştı.ç");
        }
        public void Durdur()
        {
            Console.WriteLine("Motor durdu.");
        }
    }
}
