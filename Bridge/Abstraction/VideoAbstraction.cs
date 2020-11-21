using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction
{
    public class VideoAbstraction
    {
        protected IVideoMode _videoMode;

        public IVideoMode VideoMode
        {
            set { _videoMode = value; }
        }
        public virtual void ShowScreen()
        {
            Console.WriteLine(_videoMode.GetScreen());
        }
    }
}
