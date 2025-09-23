using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    internal class Hesap
    {
        private double bakiye;
        public double Bakiye
        {
            get { return bakiye; }
            private set
            {
                if (value >= 0)
                    bakiye = value;
            }
        }
        public void ParaYatir(double miktar)
        {
            if (miktar > 0)
                bakiye += miktar;
        }
        public void ParaCek(double miktar)
        {
            if (miktar > 0 && miktar <= bakiye)
                bakiye -= miktar;
        }
    }
}
