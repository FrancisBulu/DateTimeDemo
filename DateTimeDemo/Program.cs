using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int someInteger; //declaratie
            someInteger = 10; //initialisatie
            char someChar;
            someChar = 'A';
            DateTime datum;
            datum = new DateTime(2002,10,25,4,15,30);
            DateTime datum2 = new DateTime();
            Console.WriteLine(datum2);
            DateTime now = DateTime.Now;
            Console.WriteLine(datum);
            Console.WriteLine(now);
        }
    }
}
