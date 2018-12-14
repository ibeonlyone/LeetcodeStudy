class Solution:
    def searchInsert(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        #二分法 O(log n) time, O(1) space
        low = 0
        high = len(nums)
        if target <= nums[low]:
            return low
        if target > nums[high-1]:
            return high
        while low < high:
            mid = low + (high - low)//2
            if target < nums[mid]:
                high = mid
            elif target > nums[mid]:
                low = mid +1
            else:
                return mid
        return low