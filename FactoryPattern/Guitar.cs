using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Guitar : IStringedInstrument
    {
        public Guitar()
        {
        }

        public void Play()
        {
            Console.WriteLine("The guitar is playing! Woooo!");
        }
    }
}
