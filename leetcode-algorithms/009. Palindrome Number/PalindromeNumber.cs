public class Solution 
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int y = x;
            double rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                //if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7))
                    //return 0;
                //if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8))
                    //return 0;
                rev = rev * 10 + pop;
            }
            if (rev == y) return true;
            else return false;





            
        }
    }