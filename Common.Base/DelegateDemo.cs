using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Base
{
    public delegate void GreetingDelegate(string name);
    public static class DelegateDemo
    {
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Good Morning, " + name);
        }

        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }

        private static void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }

        public static void TestDelegate()
        {
            GreetPeople("Liker", EnglishGreeting);
            GreetPeople("李志中", ChineseGreeting);
            Console.ReadLine();

            //232klj

        }
    }
}
