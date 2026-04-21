public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int i = nums.Length;
        int j = 0;
        Array.Resize(ref nums, nums.Length * 2);
        while(i < nums.Length){
            nums[i] = nums[j];
            j++;
            i++;
        }
        return nums;
    }
}