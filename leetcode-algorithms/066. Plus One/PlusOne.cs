public class Solution {
    public int[] PlusOne(int[] digits) {
        int i=digits.Length-1;
        digits[i]++;
        while(digits[i]==10&&i>0){
            digits[i]=0;
            digits[i-1]++;
            i--;
        }
        if(digits[0]==10){
            int[] newDigits = new int[digits.Length+1];
            newDigits[0]=1;
            return newDigits;
        }else
            return digits;
    }
}