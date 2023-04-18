namespace Module18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFilePath = $"{Environment.CurrentDirectory}\\video.mp4";

            Console.WriteLine("Введите url:");
            var urlVideo = Console.ReadLine();
            
            Console.WriteLine();

            try
            {
                var sender = new Sender();
                var command = new YouTubeVideoCommand(new YoutubeExplode.YoutubeClient());
                sender.SetCommand(command);

                sender.GetInfo(urlVideo);
                sender.LoadVideo(urlVideo, outputFilePath);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}