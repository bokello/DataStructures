public class HitCounter {

    private Queue<int> queue = new Queue<int>();
    
    public HitCounter() {
        
    }
    
    public void Hit(int timestamp) {
     
        queue.Enqueue(timestamp);
        
    }
    
    public int GetHits(int timestamp) {
        
        while(queue.Count != 0)
        {
            int diff  = timestamp - queue.Peek();
            
            if(diff >= 300)
                queue.Dequeue();
            else
                break;
        }
        
        return queue.Count;
        
        
    }
}

/**
 * Your HitCounter object will be instantiated and called as such:
 * HitCounter obj = new HitCounter();
 * obj.Hit(timestamp);
 * int param_2 = obj.GetHits(timestamp);
 */