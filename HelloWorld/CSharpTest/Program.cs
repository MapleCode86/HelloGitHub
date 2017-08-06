using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{

    class A
    {
        public char[] GetMemory()
        {
            char[] buff = { 'h', 'e', 'l', 'l', 'o' };
            return buff;
        }


    }

    class Program
    {
        public static char[] GetMemory()
        {
            char[] buff = { 'h', 'e', 'l', 'l', 'o' };
            return buff;
        }

        static void Main(string[] args)
        {
    
            char[] b = GetMemory();
            Console.WriteLine(b);
           
        }
    }
}
