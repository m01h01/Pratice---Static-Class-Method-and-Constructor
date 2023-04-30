using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice___Static_Class__Method__and_Constructor
{
    internal class Transaction
    {
        string _name;
        double _price;

        public Transaction(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string Name { get => _name; }
        
      
        public double Price { get => _price;}

        public override string ToString()
        {
            return $"{_name} - {Price.ToString("C")}";
        }
    }
}
