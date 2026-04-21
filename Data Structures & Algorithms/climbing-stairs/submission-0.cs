public class Solution {
    public int ClimbStairs(int n) {     
        return function(n, 0);
    }
    private int function(int n, int i){
        if (i >= n) return i == n ? 1 : 0;
        return function(n, i + 1) + function(n, i+2);
    }
}
