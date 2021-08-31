using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var text = "aaabbcc";
            //var result = text.Rotate(2);
            //Console.WriteLine(result);
            Rotated("aewvdws", 8);

        }

        public static string Rotated(string str , int n) {

            int strlen = str.Length;
            int num1, num2;

            num1 = strlen % n;

            if (n > strlen)
                n = n - strlen;

            if (num1 != 0)
            {
                string newStr = "";
                string revNewStr = "";

                for (int i = 0; i < n; i++)
                {
                    newStr += str[str.Length - 1 - i];
                }
                for (int i = newStr.Length - 1; i > -1; i--)
                {
                    revNewStr += newStr[i];
                }

                for (int i = 0; i < str.Length - n; i++)
                {
                    revNewStr += str[i];
                }


                Console.WriteLine(revNewStr);
                return revNewStr;

            }
            else {
                return str;
            }
            
        }

    }

    /* Write your code below this line*/
}
