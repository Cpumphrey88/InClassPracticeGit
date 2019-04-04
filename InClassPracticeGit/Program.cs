using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassPracticeGit
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintToScreen();
        }

        //make custom method
        //setting the access modifier to public

        public static void PrintToScreen()
        {
            Console.Write("Hello World");
            Console.ReadLine();
        }
    }
}
