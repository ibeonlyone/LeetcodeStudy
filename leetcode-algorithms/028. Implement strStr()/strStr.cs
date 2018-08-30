public class Solution {
    public int StrStr(string haystack, string needle) {
        if (String.IsNullOrEmpty(needle))
            {
                return 0;
            }
            int haystackLength = haystack.Length;
            int needleLength = needle.Length;

            if (haystackLength < needleLength) {
                return -1;
            }

            char[] haystackChars = haystack.ToCharArray();
            char[] needleChars = needle.ToCharArray();

            int i = 0;
            
            for (; i <= haystackLength - needleLength; i++) {
                int j = i;
                int k = 0;
                while (haystackChars[j]==needleChars[k]) {
                    if (k == needleLength - 1) {
                        return i;
                    }
                    j++;
                    k++;
                }
            }

            return -1;
    }
}