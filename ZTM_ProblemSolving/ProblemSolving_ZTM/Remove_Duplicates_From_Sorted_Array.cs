using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_ZTM
{
    public class RemoveDuplicatesFromArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    nums[i++ + 1] = nums[j];
                }
            }

            return ++i;
        }
    }
}
