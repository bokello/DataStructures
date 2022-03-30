public class Solution {
    public int CountKDifference(int[] nums, int k) {
        
        int totalCount = 0;
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        foreach(int num in nums)
        {            
            totalCount += map.GetValueOrDefault(num + k,0);
            totalCount += map.GetValueOrDefault(num - k,0);
            
            map[num] = map.GetValueOrDefault(num,0) + 1;
            
        }
        
        return totalCount;       
        
    }
}