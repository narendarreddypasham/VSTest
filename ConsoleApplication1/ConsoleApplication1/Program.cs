using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var todaytime = DateTime.Now;
            var futuretime = todaytime.AddDays(47);
            var testtime = todaytime.ToShortDateString();
            Console.WriteLine(todaytime.AddDays(-14));
            Console.WriteLine(futuretime.AddDays(-14));
            Console.WriteLine(testtime);
            Console.ReadLine();
        }
    }
}
