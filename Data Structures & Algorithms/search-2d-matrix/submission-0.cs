public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        bool present = false;
        foreach(int[] row in matrix){
            int l =0, r= row.Length - 1;
            while (l <= r){
                int mid = (l + r) / 2;
                if (row[mid] > target){
                    r = mid - 1;
                }
                else if (target > row[mid]){
                    l = mid + 1;
                }
                else{
                    present = true;
                    break;
                }
            }
        }
        return present;
    }
}
