using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpract1
{
    internal interface IRobot
    {
        public void Ilerle();
        public void SesCikar();
    }
    public class Robot : IRobot
    {
        public void Ilerle()
        {
            Console.WriteLine("Robot ilerliyor.");
        }
        public void SesCikar()
        {
            Console.WriteLine("Robot ses cikardi.");
        }
    }

}
