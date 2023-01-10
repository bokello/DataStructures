/*
 * @lc app=leetcode id=208 lang=java
 *
 * [208] Implement Trie (Prefix Tree)
 */

// @lc code=start
class Trie {

    TrieNode root;

    public Trie() {
        
        root = new TrieNode();
    }
    
    public void insert(String word) {
        
        TrieNode node = root;

        for(int i=0;i < word.length(); i++)
        {
            char currentChar = word.charAt(i);

            if(!node.containsKey(currentChar))
                node.put(currentChar,new TrieNode());

            node = node.get(currentChar);

        }

        node.setEnd();

    }
    
    public boolean search(String word) {
        
    }
    
    public boolean startsWith(String prefix) {
        
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.insert(word);
 * boolean param_2 = obj.search(word);
 * boolean param_3 = obj.startsWith(prefix);
 */
// @lc code=end

