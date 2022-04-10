public class Solution {
    public int CalPoints(string[] ops) {
     
        int score = 0;
        Stack<int> stk = new Stack<int>();
        
        foreach(string str in ops)
        {
            
            if(str.Equals("+"))
            {
                int top = stk.Pop();
                int newTop = stk.Peek() + top;
                
                stk.Push(top);
                stk.Push(newTop);                
                
            }
            else if(str.Equals("D"))
            {
                stk.Push(2 * stk.Peek());                
            }
            else if(str.Equals("C"))
            {
                stk.Pop();
            }
            else
            {
                stk.Push(int.Parse(str));
            }
            
        }
        
        while(stk.Count !=0)
            score += stk.Pop();
        
        
        return score;
        
    }
}