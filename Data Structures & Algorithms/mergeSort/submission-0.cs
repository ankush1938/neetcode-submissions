// Definition for a pair.
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> MergeSort(List<Pair> pairs) {
         return Sort(pairs, 0, pairs.Count - 1);
    }
    public List<Pair> Sort(List<Pair> pairs, int st, int end){
        if(end - st + 1 <= 1){
            return pairs;
        }
        int mid = (st + end) / 2;
        Sort(pairs, st, mid);
        Sort(pairs, mid + 1, end);
        Merge(pairs, st, mid, end);
        return pairs;
    }
    private void Merge(List<Pair> pairs, int st, int mid, int end){
        int i = 0, j = 0, k = st;
        List<Pair> L = new List<Pair>(pairs.GetRange(st, mid - st + 1));
        List<Pair> R = new List<Pair>(pairs.GetRange(mid + 1, end - mid));
        while (i < L.Count && j < R.Count){
            if(L[i].Key <= R[j].Key){
                pairs[k] = L[i];
                i++;
            }
            else{
                pairs[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < L.Count) {
            pairs[k] = L[i];
            i++;
            k++;
        }
        while (j < R.Count) {
            pairs[k] = R[j];
            j++;
            k++;
        }
    }
}
