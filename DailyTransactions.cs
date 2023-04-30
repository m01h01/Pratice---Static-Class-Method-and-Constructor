using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pratice___Static_Class__Method__and_Constructor
{
    static class DailyTransactions
    {
        static DateTime _now = DateTime.Now;
        static List<Transaction> _transactions;

        static DailyTransactions() 
        { 
            Transactions = new List<Transaction>();    
        }

        internal static List<Transaction> Transactions { get => _transactions; set => _transactions = value; }
       
        public static DateTime Now { get => _now; set => _now = value; }

        public static void AddTransaction()
        {
            //_transactions.Add(transaction);
            Transactions.Add(new Transaction("Cookie", 2));
            Transactions.Add(new Transaction("Coke", 3));
            Transactions.Add(new Transaction("Sandwich", 5));
            Transactions.Add(new Transaction("Water", 2));
            Transactions.Add(new Transaction("Ice cream", 4));
        }
        static double CalculateTotal()
        {
            double total = 0;
            foreach (Transaction item in _transactions)
            {
                total += item.Price + (item.Price * BusinessInfo.TaxAmount);
            }
            return total;
        }
        public static void DisplayAllInfo()
        {
            Console.WriteLine($"Your Purchases:{Now.ToLongDateString()}");
            foreach (Transaction transaction in Transactions) 
            {
                Console.WriteLine (transaction.ToString());
            }
            Console.WriteLine($"Tax:10%");
            Console.WriteLine($"Total After Tax: {CalculateTotal().ToString("C")}");

        }

    }
}
