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
        public void GetInfo(string urlVideo)
        {
            var videoInfo = youtubeClient?.Videos.GetAsync(urlVideo);
            Console.WriteLine($"Название видео: {videoInfo.Value.Result.Title}\n");
            Console.WriteLine($"Автор видео: {videoInfo.Value.Result.Author}\n");
            Console.WriteLine($"Описание видео: {videoInfo.Value.Result.Description}\n");
        }

        public void LoadVideoAsync(string urlVideo, string outputFilePath)
        {
            Console.WriteLine("Скачивание видео");
            youtubeClient?.Videos.DownloadAsync(urlVideo, outputFilePath);
            Console.WriteLine("Скачивание завершено");
        }
    }
}
