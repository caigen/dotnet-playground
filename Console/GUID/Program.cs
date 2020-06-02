using System;

namespace GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 10; ++i)
            {
                System.Guid guid = System.Guid.NewGuid();
                
                System.Console.WriteLine(guid.ToString());
            }
        }
    }
}
