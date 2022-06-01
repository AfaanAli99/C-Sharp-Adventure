using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = i+10;
            //}

            //for(int j = 0; j<nums.Length; j++)
            //{
            //    Console.WriteLine("Element{0} = {1}", j, nums[j]);
            //}

            //int counter = 0;
            //foreach (int k in nums)
            //{
            //    Console.WriteLine("Element{0} = {1}", counter, k);
            //    counter++;
            //} 

            string[] friends = new string[5];
            friends[0] = "Afaan";
            friends[1] = "Bittu";
            friends[2] = "Loid";
            friends[3] = "Anya";
            friends[4] = "Guts";

            
            foreach (string k in friends)
            {
                Console.WriteLine($"Hello {k}");
            }
        }
    }
}

