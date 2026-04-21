public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0,maxcount = 0;
        foreach(int i in nums){
            if( i == 1){
                count++;
            }
            else{
                if (count > maxcount)
                {
                    maxcount = count;
                    
                }
                count = 0;
            }
        }
        if(count > maxcount){
            maxcount = count;
        }
        return maxcount;
        
    }
}