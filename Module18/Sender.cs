using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    internal class Sender
    {
        ICommand command;       
        public void SetCommand(ICommand command) => this.command = command;
        public async Task LoadVideo(string urlVideo, string outputFilePath) => await command.LoadVideoAsync(urlVideo, outputFilePath);
        public void GetInfo(string urlVideo)=> command.GetInfo(urlVideo);
    }
}
