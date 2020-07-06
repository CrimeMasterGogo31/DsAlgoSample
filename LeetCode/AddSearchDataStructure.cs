public class WordDictionary
{
    TrieNode root;
    /** Initialize your data structure here. */
    public WordDictionary()
    {
        root = new TrieNode();
    }

    /** Adds a word into the data structure. */
    public void AddWord(string word)
    {
        var node = root;
        foreach (var w in word)
        {
            var ch = w - 'a';
            if (node.list[ch] == null)
            {
                node.list[ch] = new TrieNode();
            }
            node = node.list[ch];
        }
        node.isword = true;
        node.word = word;
        return;

    }

    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word)
    {
        var node = root;
        var iswordFound = false;


        return Search(node, word, 0);

    }

    public bool Search(TrieNode node, string word, int ind)
    {
        for (int i = ind; i < word.Length; i++)
        {
            var w = word[i];
            if (w == '.')
            {
                foreach (var l in node.list)
                {
                    if (l != null)
                    {
                        var res = Search(l, word, i + 1);
                        if (res == true)
                            return true;
                    }
                }
            }
            else
            {
                var ch = w - 'a';
                if (node.list[ch] != null)
                {
                    return Search(node.list[ch], word, i + 1);
                }
                else
                {
                    return false;
                }
            }
        }
        if (word[word.Length - 1] == '.')
        {
            return node != null;
        }
        else
        {
            return node.isword;
        }

    }
}

public class TrieNode
{
    public TrieNode[] list;
    public string word;
    public bool isword;

    public TrieNode()
    {
        list = new TrieNode[26];
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
