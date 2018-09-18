public class Solution {
    public string AddBinary(string a, string b) {
       int i=a.Length-1;
       int j=b.Length-1;
       int carry=0;
       string res="";
       while(i>=0||j>=0){
           switch ((i>=0?a[i]-'0':0)+(j>=0?b[j]-'0':0)+carry)
           {
               case 0:
                carry = 0;
                res="0"+res;
                break;

                case 1:
                carry = 0;
                res="1"+res;
                break;

                case 2:
                carry = 1;
                res="0"+res;
                break;

                case 3:
                carry = 1;
                res="1"+res;
                break;
           }
           i--;
           j--;
       }
       if (carry==1)
       {
           res = "1" + res;
       }
       return res;
        
    }
}