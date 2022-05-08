using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Afaan";

            string message = "my name is " + myname;

            string capsmessage =  message.ToUpper();
            
            string lowmessage = message.ToLower();

            Console.WriteLine(lowmessage);
            Console.Read();

            CoolMethod();

            ///<summary>
            ///This is a cool method
            /// </summary>

           

        }
        static void CoolMethod() { }
    }
}

