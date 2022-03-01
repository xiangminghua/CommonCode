using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Algorithm
{
    /// <summary>
    /// 冒泡
    /// </summary>
    public class Bubbling
    {
        /// <summary>
        /// 
        /// </summary>
        public void BubblingByForeach()
        {
            int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            //打印数组
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);

            }
            Console.ReadKey();

        }

    }
}
