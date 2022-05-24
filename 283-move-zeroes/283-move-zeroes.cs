public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
      
        int lastZeroIndex = 0;
        
        for(int i=0;i < nums.Length;i++)
        {
            
            if(nums[i] != 0)
                nums[lastZeroIndex++] = nums[i];
        }
        
        for(int i=lastZeroIndex;i < nums.Length; i++)
        {
            nums[i] = 0;            
        }
        
        
    }
}