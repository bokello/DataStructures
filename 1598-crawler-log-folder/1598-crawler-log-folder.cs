public class Solution {
    public int MinOperations(string[] logs) {
        
        Stack<string> stk = new Stack<string>();
        
        foreach(string log in logs)
        {
            if(log.Equals("./"))
                continue;
            else if(log.Equals("../"))
            {
                if(stk.Count != 0)
                    stk.Pop();
            }
            else
                 stk.Push("a");            
        }
        
        return stk.Count;
        
    }
}