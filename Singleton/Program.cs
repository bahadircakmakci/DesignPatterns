using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam_1 = SingletonClass.Sinif.Toplam(1, 2);
            Console.WriteLine(toplam_1);
            Console.ReadKey();  
        }
    }
}
