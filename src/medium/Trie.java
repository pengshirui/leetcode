package medium;

class TrieNode {
    // Initialize your data structure here.
    TrieNode[] children = new TrieNode[26];
    boolean isWord;
}

//      root
//        |
//  a b c d .... z
public class Trie {
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }

    // Inserts a word into the trie.
    public void insert(String word) {
        char[] charArr = word.toCharArray();
        TrieNode last = treeWalk(word);
        last.isWord = true;
    }

    // Returns if the word is in the trie.
    public boolean search(String word) {
        char[] charArr = word.toCharArray();
        TrieNode cur = root;
        for (int i = 0; i < charArr.length; i++) {
            if (cur.children[charArr[i] - 'a'] == null) {
                return false;
            }
            cur = cur.children[charArr[i] - 'a'];
        }
        return cur.isWord;
    }

    // Returns if there is any word in the trie
    // that starts with the given prefix.
    public boolean startsWith(String prefix) {
        char[] charArr = prefix.toCharArray();
        TrieNode cur = root;
        for (int i = 0; i < charArr.length; i++) {
            if (cur.children[charArr[i] - 'a'] == null) {
                return false;
            }
            cur = cur.children[charArr[i] - 'a'];
        }
        return true;
    }

    private TrieNode treeWalk(String s) {
        char[] charArr = s.toCharArray();
        TrieNode cur = root;
        for (int i = 0; i < charArr.length; i++) {
            if (cur.children[charArr[i] - 'a'] == null) {
                cur.children[charArr[i] - 'a'] = new TrieNode();
            }
            cur = cur.children[charArr[i] - 'a'];
        }
        return cur;
    }
}
