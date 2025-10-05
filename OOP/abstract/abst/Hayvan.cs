using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abst
{
    abstract class Hayvan
    {
        public abstract void SesCikar(); // Govdesiz
        public void Yas() //gövdeli, ortak davranış
        {
            Console.WriteLine("Hayvan yaşıyor.");
        }
    }
    class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("miyav!");
        }
    }
}
