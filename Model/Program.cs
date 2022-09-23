using System;
using System.Collections.Generic;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Model m = new Model();
            
            m.CloudSync();

            Console.WriteLine("Exiting");
        }
    }
}
