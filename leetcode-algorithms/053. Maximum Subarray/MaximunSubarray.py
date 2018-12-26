class Solution:
    def maxSubArray(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        SumMax = [0 for i in range(len(nums))]
        SumMax[0] = nums[0]
        result = SumMax[0]
        for i in range(1,len(nums)):
            SumMax[i] = nums[i] + max(SumMax[i-1],0)
            result = max(result,SumMax[i])
        return result
        