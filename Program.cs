namespace Pratice___Static_Class__Method__and_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BusinessInfo.BusinessName);
            DailyTransactions.AddTransaction();
            DailyTransactions.DisplayAllInfo();
        }
    }
}