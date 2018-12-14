class Solution:
    def strStr(self, haystack, needle):
        """
        :type haystack: str
        :type needle: str
        :rtype: int
        """ 
        if needle:
            return haystack.find(needle)
        else:
            return 0