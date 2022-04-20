public class Solution {
    public int CountKDifference(int[] nums, int k) {
      
     int count = 0;   
     Dictionary<int,int> map = new Dictionary<int,int>();
        
     foreach(int num in nums)
     {
                 
         count += map.GetValueOrDefault(num + k,0);
         count += map.GetValueOrDefault(num - k,0);  
         
         map[num] = map.GetValueOrDefault(num,0) + 1;
     }
            
     return count;
        
    }
}