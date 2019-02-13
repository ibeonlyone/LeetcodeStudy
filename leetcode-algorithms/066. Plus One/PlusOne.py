class Solution:
    def plusOne(self, digits):
        """
        :type digits: List[int]
        :rtype: List[int]
        """
        length = len(digits)
        while(length != 0 and digits[length-1] == 9):
            digits[length-1] = 0
            length -= 1
        if(length == 0):
            digits.insert(0,1)
        else:
            digits[length-1] += 1
        return digits