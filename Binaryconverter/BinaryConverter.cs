using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryConverter
{
    public static class BinaryConverter 
    {
        public static string StandartConvert(int number) 
        {
            return Convert.ToString(number, 2); 
        }
        public static string MyConvert(int number) 
        {
            string result = string.Empty; 
            int modulo; 

            while (true) 
            {
                if (number == 0) 
                    break; 

                modulo = number % 2; 
                number /= 2; 
                result += modulo; 
            }
            char[] symbols = result.ToCharArray();                                      
            result = string.Empty; 

            for (int i = symbols.Length - 1; i >= 0; i--)                                              
            {
                result += symbols[i]; 
            }
            return result; 
        }
    }
}
