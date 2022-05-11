using System;

namespace Challange3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte newByte = 122;
            sbyte newSByte = -122;
            int newInt = 99;

            short newShort = 30000;
            long newLong = 99999999999999999;

            float newFloat = 0.1f;
            double newDouble = 3.1415;

            bool newBool = true;
            string newString = "I Control text";
            string numString = "1699";
            //char newChar ="@";
            int StringToNum = int.Parse(numString);

            //int StringToNum;
            /*nncndns
             * 
             * 
             */

            Console.WriteLine($"Byte {newByte},\nsByte{newSByte},\nint{newInt},\nShort{newShort},\nLong{newLong},\nFloat{newFloat},\nDouble{newDouble}\nBoolean{newBool},\nString {newString}");
            Console.WriteLine(StringToNum);
        }
    }
}

