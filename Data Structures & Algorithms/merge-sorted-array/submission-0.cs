public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = 0, j = 0, k = 0;
        int[] nums = new int[m];
        Array.Copy(nums1, nums, m);
        while (i < m && j < n){
            if(nums2[j] < nums[i]){
                nums1[k] = nums2[j];
                j++;
            }
            else{
                nums1[k] = nums[i];
                i++;
            }
            k++;
        }
        while (i < m){
            nums1[k] = nums[i];
            k++;
            i++;
        }
        while(j < n){
            nums1[k] = nums2[j];
            j++;
            k++;
        }
        //nums1 = nums;
    }
}