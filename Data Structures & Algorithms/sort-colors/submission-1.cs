public class Solution {
    public void SortColors(int[] nums) {
        int[] count = new int[3]; 
        foreach(int ip in nums){
            count[ip] += 1;
        }
        int i = 0;
        for(int j = 0; j < count.Length; j++){
            for(int k = 0; k < count[j]; k++){
                nums[i] = j;
                i++;
            }
        }
    }
}