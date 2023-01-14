using PrefixTree;

static class Programm
{
    public static void Main()
    {
        Trie trie = new Trie();
        trie.Insert("cat", 10);
        trie.Insert("rat", 20);
        var cat = trie.Contains("cat");
        var rat = trie.Contains("rat");

        var catb = trie.StartsWith("ca");
        var _cat = trie.StartsWith("ac");
    }
}

