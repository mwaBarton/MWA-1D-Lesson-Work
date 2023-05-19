using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L116___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums;
            nums = new int[7];

            nums[0] = 1;
            nums[1] = 2;            
            nums[2] = 3;    
            nums[3] = 4;  
            nums[4] = 10;

            //Auto-initialise
            int[] nums2 = {1, 2, 3, 4, 10, 0, 0};

            Console.WriteLine(nums[4]);

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * 2;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }

            Console.ReadKey();
        }
    }
}
