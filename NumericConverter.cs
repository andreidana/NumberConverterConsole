using System;

namespace NumericConverter
{
    public class NumericConverter
    {
        public int baseValue;
        public int minimumValue;

        public string Convert(int inputNumber)
        {
            var convertedValue = string.Empty;

            for (; inputNumber > minimumValue; inputNumber /= baseValue)
                convertedValue += inputNumber % baseValue;

            convertedValue += inputNumber % baseValue;

            return Reverse(convertedValue);
        }

        private string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
