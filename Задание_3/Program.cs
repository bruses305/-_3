using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 5, 7 };
            int target = 5;
            int i;

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    break;
                }
                else if (nums[i] > 5)
                {
                    break;
                }
            }



            Console.WriteLine("[" + i + "]");
        }
    }
}
