using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeStudy
{
    class Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] twoSum = new int[2];
            for (int i = 0; i < nums.Length - 1; i++) {
                
                for (int j = i + 1; j < nums.Length; j++) {
                        if (nums[i] + nums[j] == target) {
                            twoSum[0] = i;
                            twoSum[1] = j;
                            break;
                        }
                    }
                
            }

            return twoSum;
        }
    }
}
