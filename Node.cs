using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixTree
{
    public class Node
    {
        public Node[] child;
        public string? value;
        const int _alphabet = 128;

        public Node()
        {
            child = new Node[_alphabet];
            value = null;
        }

        public Node Add(char c)
        {

            child[c] = new Node();
            return child[c];
        }
    }
}
