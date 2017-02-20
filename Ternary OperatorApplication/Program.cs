using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_OperatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        string name1 = "Rohan";
        string name2 = "Ram";
        var result = name1.Length < 5?name1:name2;
        Console.WriteLine(result);
        Console.ReadLine();
        }
    }
}
