using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Banjo : IStringedInstrument
    {
        public Banjo()
        {
        }

        public void Play()
        {
            Console.WriteLine("The banjo is heckin' country! Yee-haw!");
            Console.WriteLine("DING-DINGA-LING-LING");
        }
    }
}
