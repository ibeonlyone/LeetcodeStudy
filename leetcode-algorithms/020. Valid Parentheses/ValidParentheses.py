class Solution:
    def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        if s == "":
            return True

        list1 = []
        for char in s:
            if char == "]":
                if len(list1) == 0 or list1.pop() != "[":
                    return False
            elif char == "}":
                if len(list1) == 0 or list1.pop() != "{":
                    return False
            elif char == ")":
                if len(list1) == 0 or list1.pop() != "(":
                    return False
            else:
                list1.append(char)
        if len(list1) == 0:
            return True
        else:
            return False