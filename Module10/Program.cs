namespace Module10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new Writer();
            writer.Write();
        }
    }
}