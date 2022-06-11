public class Solution {
   public int FindMin(int[] nums) {
           int result = nums[0];
      
           int left = 0;
           int right = nums.Length - 1;
           
           while(left <= right)
           {
                if(nums[left] < nums[right]){
                   result = Math.Min(result,nums[left]);
                break;}

                int midpoint = left + (right-left)/2;

                result = Math.Min(result,nums[midpoint]);

                if(nums[midpoint] >= nums[left])
                   left = midpoint+1;
                else
                   right = midpoint-1;                
           }

           return result;

        }
}