using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Concrete
{
    public class VideoRefinedAbstraction: VideoAbstraction
    {
        public override void ShowScreen()
        {
            Console.WriteLine(_videoMode.GetScreen());
        }
    }
}
