namespace Task17._6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculateInterest(new CalculateOrdinary(), new Account());
            Calculator.CalculateInterest(new CalculateSalary(), new Account());
        }
    }
}