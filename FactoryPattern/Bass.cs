using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Bass : IStringedInstrument
    {
        public Bass()
        {
        }

        public void Play()
        {
            Console.WriteLine("The bass growls!!! Wooo!");
            Console.WriteLine("BOOM");
        }
    }
}
