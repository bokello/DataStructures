public class Solution {
    public int PivotIndex(int[] nums)
    {
        
        int index = -1;
  
        int sum=0;
        int start = 0;
        
        foreach(int x in nums)
            sum += x;
        
        for(int i=0;i < nums.Length; i++)
        {
            
            sum -= nums[i];
            
            if(sum == start)
                return i;
            
            start += nums[i];
        }
        
        
        return index;
    }
}