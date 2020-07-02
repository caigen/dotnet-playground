using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void Test(List<string> list, string tag)
        {
            List<string> listFiltered = list.Where(c => c.StartsWith(tag + ":")).ToList();

            foreach (string c in listFiltered)
            {
                Console.WriteLine(c);
            }
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("hello:hello");
            list.Add("world:world");
            string tag = "hello";

            Test(list, tag);
        }
    }
}
