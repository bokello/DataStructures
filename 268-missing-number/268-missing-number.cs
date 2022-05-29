public class Solution {
    public int MissingNumber(int[] nums) {
        
        int n = nums.Length;
        int totalSum = 0;
        
        int expectedSum = n * (n + 1) / 2;
        
        foreach(int i in nums)
          totalSum += i;
        
        return expectedSum - totalSum;
        
        
    }
    
    
}