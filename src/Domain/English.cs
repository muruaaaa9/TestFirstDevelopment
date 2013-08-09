// ReSharper disable CheckNamespace
namespace Domain.Tests
// ReSharper restore CheckNamespace
{
    public class English    
    {
        public static string NumberToEnglish(int number)
        {
            if (number == 100)
                return "one hundred";
            if (number < 100)
                return TranslateOneToNinetyNine(number);
            string result = string.Concat("one hundred and ", TranslateOneToNinetyNine(number - 100));
            return result;
        }

        private static string TranslateOneToNinetyNine(int number)
        {
            if (number < 20)
                return TranslateOneToNineteen(number);

            int units = number%10;
            int tens = number/10;
            string result = "";

            switch (tens)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "forty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                default:
                    result = "ninety";
                    break;
            }

            if (units != 0)
                result = string.Concat(result, " ", TranslateOneToNineteen(units));
            return result;
        }

        private static string TranslateOneToNineteen(int number)
        {
            switch (number)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                default:
                    return "twenty";
            }
        }
    }
}