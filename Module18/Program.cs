namespace Module18
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string outputFilePath = $"{Environment.CurrentDirectory}";

            Console.WriteLine("Введите url:");
            var urlVideo = Console.ReadLine();
            
            Console.WriteLine();

            try
            {
                var sender = new Sender();
                var command = new YouTubeVideoCommand(new YoutubeExplode.YoutubeClient());
                sender.SetCommand(command);

                sender.GetInfo(urlVideo);
                await sender.LoadVideo(urlVideo, outputFilePath);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}