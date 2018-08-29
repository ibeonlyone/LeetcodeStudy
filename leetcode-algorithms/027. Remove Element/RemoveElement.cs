public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int Length = nums.Length;
        for(int i=0;i<Length;i++)
        {
            if(nums[i]==val)
            {
                nums[i]=nums[Length-1];
                Length -= 1;
                i--;
            }
        }
        return Length;
    }
}