using System;

namespace NumericConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericConverter converter = new BinaryConverter();
            int convertedValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(converter.Convert(convertedValue));
            Console.ReadLine();
        }
    }
}
