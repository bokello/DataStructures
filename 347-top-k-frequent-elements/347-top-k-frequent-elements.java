class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        
       HashMap<Integer,Integer> map = new HashMap();
       PriorityQueue<Map.Entry<Integer,Integer>> heap = new PriorityQueue<>(
          (a,b) -> (b.getValue() - a.getValue())
       );
        
       int[] result  = new int[k];
        
       for(int num : nums)
           map.put(num,map.getOrDefault(num,0) + 1);
        
       heap.addAll(map.entrySet());
           
       for(int i=0;i < k;i++)
       {
           Map.Entry<Integer,Integer> entry = heap.poll();           
           result[i] = entry.getKey();           
       }
           
        
       return result;
        
    }
}