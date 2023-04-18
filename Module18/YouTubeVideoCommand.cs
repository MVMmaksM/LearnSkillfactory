using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18
{
    internal class YouTubeVideoCommand : ICommand
    {
        YoutubeClient? youtubeClient;
        public YouTubeVideoCommand(YoutubeClient youtubeClient)
        {
            this.youtubeClient = youtubeClient;
        }
        public void GetInfo(string urlVideo) => youtubeClient?.Videos.GetAsync(urlVideo);
        public void LoadVideo(string urlVideo, string outputFilePath) => youtubeClient?.Videos.DownloadAsync(urlVideo, outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));
    }
}
