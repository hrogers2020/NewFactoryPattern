using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStrings;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of strings for the instrument you want to create:");

                input = int.TryParse(Console.ReadLine(), out numOfStrings);

            } while (input == false);

            var instrument = InstrumentFactory.GetInstrument(numOfStrings);
            instrument.Play();

        }
    }
}
