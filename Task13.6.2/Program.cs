using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Task13_6_2
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

            var noPunctuationText = new string(textFile.Where(c => !char.IsPunctuation(c)).ToArray());
            var words = noPunctuationText.Split(' ');
            var wordsNotEmpty = words.Where(w=> !string.IsNullOrEmpty(w)); 

            Dictionary<string, int> keyValueWords = new Dictionary<string, int>();

            foreach (var word in wordsNotEmpty)
            {
                if (keyValueWords.Keys.Contains(word))
                {
                    keyValueWords[word]++;
                }
                else
                {
                    keyValueWords.Add(word, 1);
                }
            }

            var result = keyValueWords.OrderByDescending(w => w.Value);

            int i = 0;
            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                i++;

                if (i==10)
                {
                    return;
                }
            }
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