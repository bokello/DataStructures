public class Solution {
    public int NumberOfSteps(int num) {
     
        int count = 0;
        
        while(num > 0)
        {
            if(isEven(num))
                num /= 2;
            else
                num -=1;
            
            count++;
        }
        
        return count;
    }
    
    private bool isEven(int n)
    {        
        if(n %2 == 0)
            return true;
        
        return false;        
    }
}