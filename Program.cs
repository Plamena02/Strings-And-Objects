using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Низове_и_знаци
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object c = a+" "+ b;
            string f = (string)c;
            Console.WriteLine(f);
        }
    }
}
