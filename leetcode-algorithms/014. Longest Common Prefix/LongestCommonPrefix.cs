class CommonPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            else if (strs.Length == 1)
            {
                return strs[0];
            }
            int length = 0;
            bool finded = false;
            while (!finded)
            {
                length += 1;
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    if (strs[i] == "")
                    {
                        finded = true;
                        length -= 1;
                        break;
                    }
                    else if (strs[i].Length < length || strs[i + 1].Length < length)
                    {
                        finded = true;
                        length -= 1;
                        break;
                    }
                    else if (strs[i].ToString().Substring(0, length) != strs[i + 1].ToString().Substring(0, length))
                    {
                        finded = true;
                        length -= 1;
                        break;
                    }
                }
            }
            if (length == 0)
                return "";
            else
            {
                return strs[0].Substring(0, length);
            }
        }
    }