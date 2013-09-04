using System.Collections.Generic;
using System.Text;

namespace Domain.IntegerToRomanNumerals
{
    public class IntegerToRomanNumeralConverter
    {
        readonly Dictionary<int, string> _romanNumeralEquivalent;
        

        public IntegerToRomanNumeralConverter()
        {
            _romanNumeralEquivalent = new Dictionary<int, string>();
            LoadDictionary();
        }

        private void LoadDictionary()
        {
            _romanNumeralEquivalent.Add(1000, "M");
            _romanNumeralEquivalent.Add(500, "D");
            _romanNumeralEquivalent.Add(100, "C");
            _romanNumeralEquivalent.Add(50, "L");
            _romanNumeralEquivalent.Add(10, "X");
            _romanNumeralEquivalent.Add(9, "IX");
            _romanNumeralEquivalent.Add(5,"V");
            _romanNumeralEquivalent.Add(4,"IV");
            _romanNumeralEquivalent.Add(1,"I");
        }

        public string ToRomanNumeralString(int number)
        {
            var result = new StringBuilder();
            foreach (var individualItem  in _romanNumeralEquivalent)
            {
                while (number >= individualItem.Key)
                {
                    result.Append(individualItem.Value);
                    number = number - individualItem.Key;
                }
            }
            return result.ToString();
        }


    }
}