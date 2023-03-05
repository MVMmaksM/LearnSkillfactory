using System.Diagnostics;
using System.Text;
using System.Xml;

namespace Task13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathFile = @"C:\Users\Maks\Downloads\Text1.txt";
            var textFile = ReadFile(pathFile);

            if (string.IsNullOrEmpty(textFile))
            {
                return;
            }

            var arraySplit = textFile.Split(' ');

            var stopWatchList = Stopwatch.StartNew();

            List<string> listWords = new List<string>();
            //listWords.AddRange(arraySplit);

            foreach (var word in arraySplit)
            {
                listWords.Add(word);
            }

            Console.WriteLine($"Добавление в List<string>: {stopWatchList.Elapsed.TotalMilliseconds}");

            var stopWatchLinked = Stopwatch.StartNew();

            LinkedList<string> linkedWords = new LinkedList<string>();
            foreach (var word in arraySplit)
            {
                linkedWords.AddFirst(word);
            }

            Console.WriteLine($"Добавление в LinkedList<string>: {stopWatchLinked.Elapsed.TotalMilliseconds}");
        }

        static string ReadFile(string pathFile)
        {
            string textFile = string.Empty;

            try
            {
                if (File.Exists(pathFile))
                {
                    using (StreamReader streamReader = new StreamReader(pathFile))
                    {
                        textFile = streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return textFile;
        }
    }
}