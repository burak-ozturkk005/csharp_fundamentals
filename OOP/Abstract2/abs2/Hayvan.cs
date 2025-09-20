using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace abs2
{
    internal abstract class Hayvan
    {
        public string Ad { get; set; }
        public abstract void SesCikar();
        public virtual void YemekYe()
        {
            Console.WriteLine($"{Ad} yemek yiyor.");
        }
    }
    internal class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyav miyav");
        }
        public override void YemekYe()
        {
            Console.WriteLine("süt içiyor.");
        }
    }
}
