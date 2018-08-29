public class Solution {
    public bool IsValid(string s) {
         if (String.IsNullOrEmpty(s)) {
                return true;
            }
            string Queue = "";
            char[] strs = s.ToCharArray();
            int i = 0;
            for (; i < strs.Length; i++) {
                switch (strs[i]) {
                    case '(':
                        Queue = String.Concat(strs[i],Queue);
                        break;
                    case '{':
                        Queue = String.Concat(strs[i], Queue);
                        break;
                    case '[':
                        Queue = String.Concat(strs[i], Queue);
                        break;
                    case ')':
                        if (!Queue.StartsWith("("))
                        {
                            return false;
                        }
                        else
                        {
                            Queue = Queue.Remove(0, 1);
                        }
                        break;
                    case '}':
                        if (!Queue.StartsWith("{"))
                        {
                            return false;
                        }
                        else
                        {
                            Queue = Queue.Remove(0, 1);
                        }
                        break;
                    case ']':
                        if (!Queue.StartsWith("["))
                        {
                            return false;
                        }
                        else
                        {
                            Queue = Queue.Remove(0, 1);
                        }
                        break;
                }
            }
            if (Queue.Length > 0)
                return false;
            else
                return true;
    }
}