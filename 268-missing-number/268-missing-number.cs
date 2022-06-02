public class Solution {
    public int MissingNumber(int[] nums) {
        
        
        int x = nums.Length;
        
        
        for(int i=0;i < nums.Length; i++)
        {
            
            x ^= i ^ nums[i];
            
        }
        
        return x;
            
        
       /* int n = nums.Length;
        int totalSum = 0;
        
        int expectedSum = n * (n + 1) / 2;
        
        foreach(int i in nums)
          totalSum += i;
        
        return expectedSum - totalSum;
        */
        
    }
    
    
}