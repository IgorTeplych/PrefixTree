﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixTree
{
    public class Trie
    {
        Node root;
        public Trie()
        {
            root = new Node();
            root.IsLeaf = false;
        }
        public void Insert(string word, int key)
        {
            Node node = root;
            char[] chars = word.ToCharArray();
            int count = 0;
            while (count < chars.Length)
            {
                node.IsLeaf = false;
                node = node.Next(chars[count]);
                count++;
            }
            node.Key = key;
        }
        public bool Contains(string word)
        {
            Node node = Search(word);
            if (node == null)
                return false;
            else
            {
                if (node.Key == null)
                    return false;
                else
                    return true;
            }
        }
        public Node Search(string word)
        {
            Node node = root;
            char[] chars = word.ToCharArray();
            int count = 0;
            while (count < chars.Length)
            {
                node = node.Childs[chars[count]];
                count++;
            }
            return node;
        }
        public void Delete(string word)
        {
            Node node = root;
            char[] chars = word.ToCharArray();
            int count = 0;
            while (count < chars.Length - 1)
            {
                node = node.Childs[chars[count]];
                count++;
            }
            node.Childs[chars[count]] = null;
        }
        public bool StartsWith(string prefix)
        {
            Node node = root;
            char[] chars = prefix.ToCharArray();
            int count = 0;
            while (count < chars.Length)
            {
                node = node.Childs[chars[count]];
                if (node == null) return false;
                count++;
            }

            if (node == null)
                return false;
            else
                return true;
        }
    }
}
