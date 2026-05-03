public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low = 1;
        int high = piles.Max();
        int mid = 0;
        int res = piles.Max();
        while (low <= high){
            mid = (low + high) / 2;
            if (proc(mid, piles) <= h){
                high = mid - 1;
                res = mid;
            }
            else{
                low = mid + 1;
            }
        }
        return res;
    }
    private int proc(int n, int[] piles){
        int count = 0;
        foreach(int i in piles){
            int t = (int)Math.Ceiling((double)i / n);
            count += t;
        }
        return count;
    }
}
