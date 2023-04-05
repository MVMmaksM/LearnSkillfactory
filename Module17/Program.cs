namespace Module17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();

            app.Launch("connString");
            Console.WriteLine(app.DbConnection.ConnectionString);

            app.DbConnection = dbConnection.GetConnectionInstatnce("p45-db02");
            Console.WriteLine(app.DbConnection.ConnectionString);
        }
    }
}