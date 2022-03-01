using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Algorithm
{
    public class Sum1_100__n_1_
    {

        public void Sum2()
        {
            List<int> nums = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                nums.Add(i);
            }
            var a = nums[1];

            int j = 1;
            int count = 1;
            int result = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i == (j + j * (count - 1)))
                {
                    result += i;
                    count++;
                }

            }
            var a4 = result;

        }

    }
}
