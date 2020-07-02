using System;
using System.Collections.Generic;
using System.Linq;

namespace Aggregate
{
    struct data
    {
        public string name { set; get; }
        public string value { set; get; }
        public data(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<data> datas = new List<data>();
            datas.Add(new data("a", "Hello"));
            datas.Add(new data("b", "World"));
            datas.Add(new data("a", "Hello2"));
            datas.Add(new data("b", "World2"));

            int count0 = datas.Where(e => (e.name).Contains("a")).Count() ;
            Console.WriteLine(count0);

            Console.WriteLine("Hello World!");
        }
    }
}
