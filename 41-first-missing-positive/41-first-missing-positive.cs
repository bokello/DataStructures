public class Solution {
    public int FirstMissingPositive(int[] nums) {
        
        int n = nums.Length;
        bool[] temp = new bool[n + 1];
        
        for(int i=0;i < n; i++)
        {
            if(nums[i] > 0 && nums[i] <= n)
                temp[nums[i]] = true;
        }
        
        for(int j=1;j <= n ; j++)
        {
            if(!temp[j])
                return j;
        }
        
        return n + 1;
        
    }
}