public class Solution {
    public int[] RunningSum(int[] nums) {
       
        int[] output = new int[nums.Length];
        
        int runningSum = 0;
        
        for(int i=0;i < nums.Length;i++)
        {
            runningSum += nums[i];
            output[i] = runningSum;
        }
        
        return output;
    }
}