public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> stack = new Stack<int>();
        
        foreach(string token in tokens)
        {
            
            if(token == "+"||token == "-"||token == "*"||token == "/")
            {
                
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                int result = 0;
            
                switch(token)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;                   
                }
             
                stack.Push(result);
            }
            else
            {
                stack.Push(int.Parse(token));
                 
            }
        }
            
           return stack.Pop();
    }
}