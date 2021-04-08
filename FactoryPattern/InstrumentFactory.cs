using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public static class InstrumentFactory
    {
        public static IStringedInstrument GetInstrument(int stringCount)
        {
            //if(stringCount == 6)
            //{
            //    return new Guitar();
            //}

            switch (stringCount)
            {
                case 4:
                    return new Bass();
                case 5:
                    return new Banjo();
                case 6:
                    return new Guitar();
                default:
                    return new Guitar();

            }
        }
    }
}
