public class Solution {
    
    int localMax=0;
    int globalMax = int.MinValue;
    
    
    public int MaxSubArray(int[] nums) {
        
        for(int i=0;i < nums.Length; i++)
        {
            localMax = Math.Max(nums[i], localMax + nums[i]);
            
            if(localMax > globalMax)
               globalMax = localMax;
            
        }
        
        return globalMax;
        
        
    }
}