public class Solution {
    public int TwoSumLessThanK(int[] nums, int k) {
        
        Array.Sort(nums);       
        
        int ans = -1;
        int left = 0;
        int right = nums.Length - 1;
        
        while(left < right)
        {            
            int sum = nums[left] + nums[right];
            
            if(sum < k)
            {
                ans  = Math.Max(ans,sum);
                left++;
            }
            else
            {
                right--;
            }
        }
        
        return ans;
    }
}