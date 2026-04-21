public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> score = new Stack<int>();
        foreach(string operation in operations){
            switch (operation){
                case "+" :
                int last1 = score.Pop();
                int last2 = score.Pop();
                score.Push(last2);
                score.Push(last1);
                score.Push(last1 + last2);
                break;
                case "D" :
                int last = score.Pop();
                score.Push(last);
                score.Push(last * 2);
                break;
                
                case "C" :
                score.Pop();
                break;
                
                default: 
                score.Push(Convert.ToInt32(operation));
                break;
            }
        }

        int total = 0;
        foreach(int i in score){
            total += i;
        }
        return total;
    }
}