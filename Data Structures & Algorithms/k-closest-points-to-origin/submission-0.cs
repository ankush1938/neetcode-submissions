public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        points = Sort(points, 0 ,points.Length - 1);
        Array.Resize(ref points, k);
        return points;
    }
    private int[][] Sort(int[][] points, int st, int end){
        if(end - st + 1 <= 1){
            return points;
        }
        int i = st, left = st;
        int[] pivot = points[end];
        double dis = Math.Sqrt((pivot[0] * pivot[0]) + (pivot[1] * pivot[1]));
        while (i < end){
            double distance = Math.Sqrt((points[i][0] *  points[i][0]) + ( points[i][1] * points[i][1]));
            if(distance < dis){
                int[] temp = points[i];
                points[i] = points[left];
                points[left] = temp;
                left++;
            }
            i++;
        }
        points[end] = points[left];
        points[left] = pivot;
        Sort(points, st, left - 1);
        Sort(points, left + 1, end);
        return points;
    }
}
