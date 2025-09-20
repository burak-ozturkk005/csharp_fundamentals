using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{
    internal class Hayvan
    {
        public string Ad { get; set; }
        public virtual void SesCikar()
        {
            Console.WriteLine("ses");
        }
    }
    internal class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyav miyav");
        }
    }
    internal class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Hav hav");
        }
    }
    internal class Kus : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Cik cik");
        }
    }
}
