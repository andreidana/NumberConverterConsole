using System;

namespace NumericConverter
{
    public class BinaryConverter
    {
        public BinaryConverter() {}

        public string ToBinary(int inputNumber)
        {
            var binaryValue = string.Empty;

            for(; inputNumber > 1; inputNumber /= 2)
                binaryValue += inputNumber % 2;

            binaryValue += inputNumber % 2;

            return Reverse(binaryValue);
        }

        private string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}