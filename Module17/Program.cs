namespace Module17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Application app = new Application();

            //app.Launch("connString");
            //Console.WriteLine(app.DbConnection.ConnectionString);

            //app.DbConnection = dbConnection.GetConnectionInstatnce("p45-db02");
            //Console.WriteLine(app.DbConnection.ConnectionString);

            //var dragonMonster = new Monster(new DragonMonster());
            //dragonMonster.Start();
            //dragonMonster.Attack();

            //var orcMosnter = new Monster(new OrcMonster());
            //orcMosnter.Start();
            //orcMosnter.Attack();

            //var client = new Client();
            //client.Request(new Target());
            //client.Request(new Adapter());

            var imgDraver = new ImageDirver();
            imgDraver.Print(new PaperPrinter());
            imgDraver.Print(new CanvasPrinterAdapter());
        }
    }
}