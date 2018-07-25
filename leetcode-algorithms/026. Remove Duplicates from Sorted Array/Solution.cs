using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeStudy
{
    class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;
            for (int i=1;i<length;i++)
            {
                for (int j=0;j<i;j++)
                {
                    if (nums[i] == nums[j])
                    {
                        KickElementToTheEnd(nums, i,length-1);
                        length--;
                        i--;
                        
                    }
                }
            }

            return length;
        }

        //kick the first element to the end of the array
        public static void KickElementToTheEnd(int[] array, int index,int end)
        {
            ReverseArray(array, index, end);
            ReverseArray(array, index, end-1);
        }

        //Reverse the order of array
        public static void ReverseArray(int[] array, int left, int right)
        {

            for (; left<right; ++left, --right)
           {
                int tmp = array[left];
                array[left] = array[right];
                array[right] = tmp;
            }
        }
    }
}
