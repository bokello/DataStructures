public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
       
        int j = 0;
        Stack<int> stack = new Stack<int>();
        int N = pushed.Length;
        
        foreach(int num in pushed)
        {
            stack.Push(num);
            
            while(stack.Count != 0 && j < N && stack.Peek() == popped[j])
            {                
                stack.Pop();
                j++;
            }            
        }
                
        return j == N;        
        
    }
}