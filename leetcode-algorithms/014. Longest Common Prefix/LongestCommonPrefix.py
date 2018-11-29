class Solution:
    def longestCommonPrefix(self, strs):
        """
        :type strs: List[str]
        :rtype: str
        """
        if len(strs) == 0:
            return ""
        length = len(strs[0])
        finded = False
        while (not finded) and length > 0:
            result = strs[0][0:length]
            for st in strs:
                if st.startswith(result):
                    finded = True
                else:
                    length -= 1
                    finded = False
                    break   
        if length == 0:
            return ""
        else:
            return result