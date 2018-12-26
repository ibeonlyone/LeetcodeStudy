class Solution:
    def countAndSay(self, n):
        """
        :type n: int
        :rtype: str
        """
        if n == 1:
            return "1"
        result = ""
        lasted = list(self.countAndSay(n-1))
        while len(lasted) != 0:
            count = 1
            head = lasted.pop(0)
            while len(lasted) != 0 and head == lasted[0]:
                count += 1
                lasted.pop(0)
            result += "".join([str(count),head])
        return result