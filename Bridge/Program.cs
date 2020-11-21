using Bridge.Abstraction;
using Bridge.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoAbstraction video = new VideoRefinedAbstraction();
            video.VideoMode = new OpenGLMode();
            video.ShowScreen();

            Console.ReadLine();
        }
    }
}
