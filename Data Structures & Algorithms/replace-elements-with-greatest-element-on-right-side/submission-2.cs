public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int max = -1;
        int temp =-1;
        for( int i = arr.Length - 1; i >= 0; i--){
            if (i == arr.Length - 1){
                max = arr[i];
                temp = max;
                arr[i] = -1;
                continue;
            }
            temp = arr[i];
            arr[i] = max;
            max = Math.Max(max,temp);
        }
        return arr;
    }
}