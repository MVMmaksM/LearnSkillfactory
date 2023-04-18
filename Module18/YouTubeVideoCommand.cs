using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

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

        public async Task LoadVideoAsync(string urlVideo, string outputFilePath)
        {
            var videoInfo = youtubeClient.Videos.GetAsync(urlVideo);
            var streamManifest = youtubeClient.Videos.Streams.GetManifestAsync(videoInfo.Result.Id);
            var streamInfo = streamManifest.Result.GetMuxedStreams().GetWithHighestVideoQuality();

            Console.WriteLine("Скачивание видео");
            await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, $"{outputFilePath}/{videoInfo.Result.Title}.{streamInfo.Container}");
            Console.WriteLine("Скачивание завершено");
        }
    }
}
