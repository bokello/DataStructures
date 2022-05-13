public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        
        IList<int> output_arr = new List<int>();
        
        for(int i=0;i < nums.Length;i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            
            if(nums[index] < 0)
                output_arr.Add(index + 1);
            nums[index] *= -1;
            
        }
        
        return output_arr;
        
    }
}