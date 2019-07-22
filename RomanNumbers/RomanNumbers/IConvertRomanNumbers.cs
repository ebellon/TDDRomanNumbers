using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    interface IConvertRomanNumbers
    {
        string ConvertFromRomanToArabic(string romanNumber);

        string ConvertFromArabicToRoman(string arabicNumber);
    }
}
