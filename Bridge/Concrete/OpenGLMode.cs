using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class OpenGLMode : IVideoMode
    {
        const string MODE_NAME = "OpenGL Mode";
        public string GetScreen()
        {
            return string.Format("Video started with {0}", MODE_NAME);
        }
    }
}
