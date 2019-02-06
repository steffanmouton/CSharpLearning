using System;

namespace Roman_Numeral_Converter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = 36;
            Converter con = new Converter();

            string result = con.RomanToDecimalCon(num);
            
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}