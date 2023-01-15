namespace PrefixTree.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        { 
        }

        [Test]
        public void InsertMethodTest()
        {
            Trie trie = new Trie();
            trie.Insert("cat", 10);
            trie.Insert("owl", 20);
            trie.Insert("dog", 30);  
            trie.Insert("elephant", 40);
            trie.Insert("hippo", 50);
            trie.Insert("car", 60);
            trie.Insert("hippoo", 61);
        }
        [Test]
        public void ContainsMethodTest()
        {
            Trie trie = new Trie();
            trie.Insert("cat", 10);
            trie.Insert("owl", 20);
            trie.Insert("dog", 30);
            trie.Insert("elephant", 40);
            trie.Insert("hippo", 50);
            trie.Insert("car", 60);
            trie.Insert("hippoo", 61);

            Assert.AreEqual(trie.Contains("cat"), true);
            Assert.AreEqual(trie.Contains("owl"), true);
            Assert.AreEqual(trie.Contains("dog"), true);
            Assert.AreEqual(trie.Contains("elephant"), true);
            Assert.AreEqual(trie.Contains("hippo"), true);
            Assert.AreEqual(trie.Contains("car"), true);
            Assert.AreEqual(trie.Contains("hippoo"), true);

            Assert.AreEqual(trie.Contains("hippooo"), false);
            Assert.AreEqual(trie.Contains("hip"), false);
        }
        [Test]
        public void SearchMethodTest()
        {
            Trie trie = new Trie();
            trie.Insert("cat", 10);
            trie.Insert("owl", 20);
            trie.Insert("dog", 30);
            trie.Insert("elephant", 40);
            trie.Insert("hippo", 50);
            trie.Insert("car", 60);
            trie.Insert("hippoo", 61);

            Assert.AreEqual(trie.Search("cat").Key, 10);
            Assert.AreEqual(trie.Search("owl").Key, 20);
            Assert.AreEqual(trie.Search("dog").Key, 30);
            Assert.AreEqual(trie.Search("elephant").Key, 40);
            Assert.AreEqual(trie.Search("hippo").Key, 50);
            Assert.AreEqual(trie.Search("car").Key, 60);
            Assert.AreEqual(trie.Search("hippoo").Key, 61);
        }
        [Test]
        public void StartsWithMethodTest()
        {
            Trie trie = new Trie();
            trie.Insert("cat", 10);
            trie.Insert("owl", 20);
            trie.Insert("dog", 30);
            trie.Insert("elephant", 40);
            trie.Insert("hippo", 50);
            trie.Insert("car", 60);
            trie.Insert("hippoo", 61);

            Assert.AreEqual(trie.StartsWith("ca"), true);
            Assert.AreEqual(trie.StartsWith("owls"), false);

            Assert.AreEqual(trie.StartsWith("elephant"), true);
            Assert.AreEqual(trie.StartsWith("elephan"), true);

            Assert.AreEqual(trie.StartsWith("elepant"), false);
        }
    }
}