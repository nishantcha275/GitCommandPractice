using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPracticecode
{
    internal class Program
    {
        public static void add(int a, int b)
        { a += b; }
        static void Main(string[] args)
        {
            Console.WriteLine("this is main branch");
            add(1, 2);
            Console.ReadLine();
        }
    }
}
