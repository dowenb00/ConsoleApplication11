using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            int n = 20;
            int n2 = 1;
            for (int i = 0; i < n; i++)
            {
                for (int x = n2; x <= n; x++)
                {
                    result += x.ToString() + ",";
                }
                n2++;
                result += "\n";
            }
            Console.WriteLine(result.Trim());
        }
    }
}
