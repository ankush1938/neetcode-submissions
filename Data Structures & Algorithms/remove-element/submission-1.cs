public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int j =0,k=0;
        foreach(int i in nums){
            if(i== val){
                continue;
            }
            nums[j]= i;
            j++;
        }
        return j;
    }
}