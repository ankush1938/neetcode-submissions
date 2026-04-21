public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> q = new Queue<int>(students);
        Queue<int> s = new Queue<int>(sandwiches);
        
        int length = students.Length;

        while(length > 0){
            int j = length;
            int k = j;
            int sand = s.Dequeue();
            while (j > 0){
                int st = q.Dequeue();
                if(st == sand){
                    length --;    
                    break;                
                }
                else{
                    q.Enqueue(st);
                }
                j--;
            }
            if(k == length){
                break;
            }
        }

        return length;
    }
}