﻿namespace PrefixTree
{
    internal class PrefTree
    {
        private Node _root;
        private string? _prevValue;
        public PrefTree()
        {
            _root = new Node();
        }
        public void insert(string value)
        {
            var node = _root;
            foreach (char c in value)
            {
                if (node.child[c] == null)
                {
                    node = node.Add(c);
                }
                else { node = node.child[c]; }
            }
            node.value = value;
            _prevValue = value;
        }

        public bool Search(string keyWord)
        {
            var node = _root;
            foreach (char c in keyWord)
            {
                if (node.child[c] == null)
                {
                    return false;
                }
                node = node.child[c];
            }
            if(node.value == null) { return false; }
            return true;
        }

        public bool StartsWith(string prefix)
        {
            var node = _root;
            var index = 0;
            if (_prevValue == null)
                return false;
            foreach (char c in prefix)
            {
                if (_prevValue[index] != c)
                    return false;

                index++;
            }
            return true;
        }
    }
}
