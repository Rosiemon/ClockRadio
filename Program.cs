using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio ClockRadio = new ClockRadio();

            Console.WriteLine("**********************************************************");
            Console.WriteLine("************ HELLO ~ This is your CLOCK RADIO ************");
            Console.WriteLine("**********************************************************");
            ClockRadio.CurrentTime();
            Console.WriteLine("**********************************************************");
            ClockRadio.ChangeSettings();
        }
    }
}
