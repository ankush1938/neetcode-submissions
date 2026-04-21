public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int j = 0;
        int[] ans = new int[2 * nums.Length];
        for (int i=0; i<2 * nums.Length;i++){
            if(j == nums.Length){
                j = 0;
            }
            ans[i] = nums[j];
            j++;
        }
        return ans;
    }
}