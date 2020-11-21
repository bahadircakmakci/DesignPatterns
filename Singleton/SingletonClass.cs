using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonClass
    {
 
        private SingletonClass() { }

        private static SingletonClass _tekNesne = new SingletonClass();
     
        public static SingletonClass Sinif { get { return _tekNesne; } }

      
        public int Toplam(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
