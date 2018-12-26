class Solution:
    def lengthOfLastWord(self, s):
        """
        :type s: str
        :rtype: int
        """
        s2 = s.rstrip()
        words = s2.split(" ")
        lastword = words.pop()
        return len(lastword)
            