public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int j = 0;
        for(int i = 0; i < nums.Length ; i++){
            if (i == 0){
                j++;
                continue;
            }
            if (nums[i] != nums[j - 1]){
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}