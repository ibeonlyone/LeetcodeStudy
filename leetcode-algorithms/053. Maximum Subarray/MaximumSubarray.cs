public class Solution {
    public int MaxSubArray(int[] A) {
            int n = A.Length;
            int[] dp = new int[n];//dp[i] means the maximum subarray ending with A[i];
            dp[0] = A[0];
            int max = dp[0];
            
            for(int i = 1; i < n; i++){
                dp[i] = A[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
                max = Math.Max(max, dp[i]);
            }
            
            return max;
    }
}