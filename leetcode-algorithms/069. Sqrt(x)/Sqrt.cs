public class Solution {
    public int MySqrt(int x) {
        if(x==1)
            return 1;
        double a = x/2;
        double b = x;
        double rap = x;
        
        while(Math.Abs(rap)>0.5){
            b = (a + x/a)/2;
            rap = a-b;
            a = b;
        }
        return (int)Math.Floor(b);
    }
}