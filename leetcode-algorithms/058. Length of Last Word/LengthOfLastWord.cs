public class Solution {
    public int LengthOfLastWord(string s) {
        string[] array = s.Split(' ');
        for(int i=array.Length-1;i>=0;i--){
            if(array[i]!=""){
                return array[i].Length;
            }
        }
        return 0 ;   
        
    }
}