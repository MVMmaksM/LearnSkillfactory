using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    internal interface ICommand
    {
        void GetInfo(string urlVideo);
        void LoadVideo(string urlVideo, string outputFilePath);
    }
}
