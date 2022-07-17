class Solution {
    public int[] twoSum(int[] nums, int target) {
        
        HashMap<Integer,Integer> map = new HashMap();
                
        for(int i=0;i < nums.length;i++)
        {            
            int N = target - nums[i];    
         
            if(map.containsKey(N))
            {
                return new int[] {map.get(N), i};
            }
            else if(!map.containsKey(nums[i]))
            {
                map.put(nums[i],i);
            }            
        }
        
        return new int[] {-1,-1};        
        
    }
}