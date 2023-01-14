using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixTree
{
    public class Node
    {
        public Node()
        {
            Childs = new Node[128];
        }
        public Node Next(char c)
        {
            if (Childs[c] == null)
                Childs[c] = new Node();

            this.IsLeaf = false;
            return Childs[c];
        }
        public Node[] Childs { get; set; }
        public bool IsLeaf { get; set; }
        public int? Key { get; set; }
    }
}
