using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peanut
{
    class inder
    {
        static void Main(string[] args)
        {
            MethodA();
        }
        public static void MethodA()
        {
            while (Peanut())
            {
                Console.WriteLine("Hello ! I am stuck in an infinite loop!");
            }
        }
        public static bool Peanut()
        {
            return true;
        }
    }
}