
public class Solution {
    public int[] TwoSum(int[] arr, int target)
    {
       
        //target = arr[i] + N
        // N = target - arr[i]
        
       Dictionary<int,int> map = new Dictionary<int,int>();
        
        for(int i=0;i < arr.Length;i++)
        {
            int N = target - arr[i];
            
            if(map.ContainsKey(N))
               return new int[]{map[N],i};
            else if(!map.ContainsKey(arr[i]))
               map.Add(arr[i],i);
        }
        
        return new int[]{-1,-1};
        
        
    }
}