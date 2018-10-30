class Solution:
    def reverse(self, x):
        """
        :type x: int
        :rtype: int
        """
        rev = 0
        plus_or_neg = 1 if x > 0 else -1
        x = abs(x)
        while x != 0:
            pop = x % 10
            x //= 10
            rev = rev * 10 + pop
            if rev > 2 ** 31 - 1 or rev * plus_or_neg < -2 ** 31:
                return 0
        return rev * plus_or_neg
