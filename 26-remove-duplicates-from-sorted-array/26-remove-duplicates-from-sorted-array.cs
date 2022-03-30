public class Solution {
    public int RemoveDuplicates(int[] nums) {
         int i = 0;

           if(nums.Count() == 0 || nums == null)
              return 0;

           for(int j=1;j < nums.Count();j++)
           {
              if(nums[i] != nums[j])
                 nums[++i] = nums[j];
           }
           
           return i +=1;
    }
}
