class Solution:
    def isPalindrome(self, x):
        """
        :type x: int
        :rtype: bool
        """
        if x < 0:
            return False
        l1 = []
        while x != 0:
            l1.append(x % 10)
            x //= 10
        l2 = l1.copy()
        l1.reverse()
        for a, b in zip(l1, l2):
            if a != b:
                return False
        return True