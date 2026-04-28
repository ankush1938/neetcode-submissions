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
    public List<Pair> QuickSort(List<Pair> pairs) {

        return Sort(pairs, 0, pairs.Count - 1);
    }
    private List<Pair> Sort(List<Pair> pairs, int st, int end){
        if(end - st + 1 <= 1){
            return pairs;
        }
        int i = st;
        int left = st;
        Pair piv = pairs[end];
        int pivot = end;
        while (i < pivot){
            if(pairs[i].Key < pairs[pivot].Key){
                Pair temp = pairs[left];
                pairs[left] = pairs[i];
                pairs[i] = temp;
                left++;
            }
            i++;
        }
        pairs[end] = pairs[left];
        pairs[left] = piv;
        Sort(pairs, st, left - 1);
        Sort(pairs, left + 1, end);
        return pairs;
    }
}
