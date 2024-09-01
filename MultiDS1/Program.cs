using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"math","VPY"},
                {"science","AJY" }
            };

            foreach(KeyValuePair<string,string> item in teachers)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(teachers["math"]);  //Accessing value using key directly.

            teachers["math"] = "VKY";
            Console.WriteLine(teachers["math"]);

            teachers.Remove("math");

            if (teachers.ContainsKey("math"))
                Console.WriteLine("");
            else
                Console.WriteLine(teachers["math"]);


        }
    }
}
