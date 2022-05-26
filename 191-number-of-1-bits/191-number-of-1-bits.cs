public class Solution {
    public int HammingWeight(uint n) 
    {        
        int count = 0;
        
        while(n != 0)
        {            
            if(!isEven(n))
              count += 1;
            
            n = n / 2;
        }       
                
        return count;
    }
    
    private bool isEven(uint x)
    {        
        if(x % 2 == 0)
            return true;
        
        return false;        
    }
}