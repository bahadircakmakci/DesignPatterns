using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ICardReaderAdapter cardReaderAdapter = new XBankCardReaderAdapter();
                var result = cardReaderAdapter.ReadCardData();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
