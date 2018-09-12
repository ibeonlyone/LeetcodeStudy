public class Solution {
    public string CountAndSay(int n) {
        if(n==1){
            return "1";
        }
        if(n==2){
            return "11";
        }
        string temp = CountAndSay(n-1);
        string result = "";
        int count = 1;
        for(int i=0;i<temp.Length-1;i++){

            if(temp[i]==temp[i+1]){
                count++;
                if(i==temp.Length-2){
                    result+=count.ToString()+temp[i];
                }
            }
             else
            {
                
                result+=count.ToString()+temp[i];
                count = 1;
                if(i==temp.Length-2){
                    result+="1"+temp[i+1];
                }
            }
            
        }
        return result;
    }
}