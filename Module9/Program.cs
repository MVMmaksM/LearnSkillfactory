namespace Module9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Diff;

            Console.WriteLine(myDelegate(10, 15));
        }

        delegate int MyDelegate(int a, int b);
        public static int Diff(int a, int b) => a - b; 
    }
}