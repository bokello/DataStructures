public class Codec {

    string alphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    Random rand = new Random();
    Dictionary<string,string> map = new Dictionary<string,string>();
    string key = string.Empty;
    
    public Codec()
    {
        key = getRandom();
    }
    
    private string getRandom()
    {
        StringBuilder sb = new StringBuilder();
        
        for(int i=0;i < 6; i++)
            sb.Append(alphabet[rand.Next(62)]);
        
        return sb.ToString();
    }
    
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        
        while(map.ContainsKey(key))
        {
            key = getRandom();
        }
        
        map.Add(key, longUrl); 
        return "http://tinyurl.com/"+ key;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        
        return map[shortUrl.Replace("http://tinyurl.com/","")];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));