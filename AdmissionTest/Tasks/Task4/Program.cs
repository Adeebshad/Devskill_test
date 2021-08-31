using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // "11110101010101010101011"
            var result = BinaryToDecimal("11110101010101010101011");
            Console.WriteLine(result);
            

        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            string  revstring = RevstringFunction(binaryNumber);
            int i;
            int strlength = revstring.Length;
            
            int value=0;
            
            for (i = 0; i < strlength; i++) {
                if(revstring[i] == '1')
                    value += powerFunction(2, i);
            }
            Console.WriteLine("result : " + value);
            return value;
            
        }

        public static string RevstringFunction(string str) {

            int strLenght = str.Length;
            string revString = "";

            for (int i = strLenght - 1; i > -1; i--) {
                revString += str[i];
            }
            return revString;
        }

        public static int powerFunction(int based, int exp) {
            int val=1;
            for (int i=0; i < exp; i++) {
                val *= based; 
            }
            return val;
        }
    }
}
