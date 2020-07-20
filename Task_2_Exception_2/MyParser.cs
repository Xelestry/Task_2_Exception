using System;

namespace Task_2_Exception_2
{
    public static class MyParser
    {
        const int ZeroSymbol = 49;
        const int NineSymbol = 57;

        public static bool StringToInt(string sourceString, out int targetInt)
        {
            targetInt = 0;

            if (IsSourceStringValid(sourceString))
            {
                int? resultNumber = ConverStringToInt(sourceString);

                if (resultNumber.HasValue)
                {
                    targetInt = resultNumber.Value;
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        private static int? ConverStringToInt(string sourceString)
        {
            int? resultNumber = 0;
            const int FormulaConst = 10;

            for (int i = 0; i < sourceString.Length; i++)
            {
                int? currentNumeral = CharToInt(sourceString[i]);

                if (currentNumeral != null)
                {
                    resultNumber = resultNumber * FormulaConst + currentNumeral;
                }
                else
                {
                    return null;
                }
            }

            return resultNumber;
        }

        private static bool IsSourceStringValid(string sourceString)
        {
            if (sourceString == string.Empty)
            {
                return false;
            }

            for (int i = 0; i < sourceString.Length; i++)
            {
                if (sourceString[i] < ZeroSymbol || sourceString[i] > NineSymbol)
                {
                    return false;
                }
            }

            return true;
        }

        private static int? CharToInt(char letter)
        {
            switch (letter)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                default:
                    return null;
            }
        }
    }
}
