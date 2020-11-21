using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Direct3DMode : IVideoMode
    {
        const string MODE_NAME = "Direct3D Mode";
        public string GetScreen()
        {
            return string.Format("Video started with {0}", MODE_NAME);
        }
    }
}
