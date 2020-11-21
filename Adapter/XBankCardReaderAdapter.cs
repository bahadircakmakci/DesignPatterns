using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class XBankCardReaderAdapter : ICardReaderAdapter
    {
        public string ReadCardData()
        {
            XBanckPostReader xBanckPostReader = new XBanckPostReader();
            return xBanckPostReader.ReadFormCard();
        }
    }
}
