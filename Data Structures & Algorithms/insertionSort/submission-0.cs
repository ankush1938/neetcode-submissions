// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> res = new List<List<Pair>>();
        int n = pairs.Count;
        for(int i = 0; i < n; i++){
            int j = i - 1;

            // Move elements that are greater than key one position ahead
            while (j >= 0 && pairs[j].Key > pairs[j + 1].Key) {
                Pair temp = pairs[j];
                pairs[j] = pairs[j + 1];
                pairs[j + 1] = temp;
                j--;
            }
            List<Pair> cloneList = new List<Pair>(pairs);
            res.Add(cloneList);
        }
        return res;
    }
}
