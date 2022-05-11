using System;

namespace Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string userInput = Console.ReadLine();

            try
            {
                int userInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter correct type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("number too long or shoert");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Enter a number");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }

            Console.ReadKey();
        }
    }
}

