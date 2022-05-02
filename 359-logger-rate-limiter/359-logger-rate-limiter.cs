public class Logger {

    Dictionary<string,int> map = new Dictionary<string,int>();
    
    public Logger() {
        
    }
    
    public bool ShouldPrintMessage(int timestamp, string message) {
        
        if(map.ContainsKey(message))
        {
            int lastTimestamp = map[message];
            
            if(timestamp >= lastTimestamp + 10 )
            {
                map[message] = timestamp;
                return true;            
            }else
            {
                return false;
            }
                
        }
        else
        {            
            map.Add(message,timestamp);
            return true;
        }
        
        return true;
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
 */