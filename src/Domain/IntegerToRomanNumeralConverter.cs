using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class IntegerToRomanNumeralConverter
    {
        Dictionary<int, string> romanNumeralEquivalent;
        

        public IntegerToRomanNumeralConverter()
        {
            romanNumeralEquivalent = new Dictionary<int, string>();
            LoadDictionary();
        }

        private void LoadDictionary()
        {
            //romanNumeralEquivalent.Add(1000, "M");
            //romanNumeralEquivalent.Add(500, "D");
            //romanNumeralEquivalent.Add(100, "C");
            romanNumeralEquivalent.Add(50, "L");
            romanNumeralEquivalent.Add(10, "X");
            romanNumeralEquivalent.Add(9, "IX");
            romanNumeralEquivalent.Add(5,"V");
            romanNumeralEquivalent.Add(4,"IV");
            romanNumeralEquivalent.Add(1,"I");
        }

        public string ToRomanNumeralString(int number)
        {
            var result = new StringBuilder();
            foreach (var individualItem  in romanNumeralEquivalent)
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