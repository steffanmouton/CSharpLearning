using System;
using System.Collections.Generic;

namespace Roman_Numeral_Converter
{
    public class Converter
    {
        Dictionary<int, string> m_dict;
        
        public string RomanToDecimalCon(int v)
        {
            int val = v;
            string result = "";
            
            m_dict = new Dictionary<int, string>();
            m_dict.Add(1000, "M");
            m_dict.Add(900, "CM");
            m_dict.Add(500, "D");
            m_dict.Add(400, "CD");
            m_dict.Add(100, "C");
            m_dict.Add(90, "XC");
            m_dict.Add(50, "L");
            m_dict.Add(40, "XL");
            m_dict.Add(10, "X");
            m_dict.Add(9, "IX");//Initialize using constructor
            m_dict.Add(5, "V");
            m_dict.Add(4, "IV");
            m_dict.Add(1, "I");

            while (val > 0)
            {
                foreach (var index in m_dict)
                {
                    if (val >= index.Key)
                    {
                        result = String.Concat(result, index.Value);
                        val -= index.Key;
                        break;
                    }
                }
            }
            return result;
        }
    }
}