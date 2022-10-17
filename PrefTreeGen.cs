namespace PrefixTree
{
    public class PrefTreeGen<T>
    {
        private NodeGen<T> _root;
        //private T? _prevValue;
        public PrefTreeGen()
        {
            _root = new NodeGen<T>();
        }
        public void insert(string keyWord, T value)
        {
            var node = _root;
            foreach(char c in keyWord)
            {
                if(node.child[c] == null)
                {
                    node = node.Add(c);
                }
            }
            node.value = value;
            //_prevValue = value;
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
            }
            return true;
        }

        //public bool StartsWith(string prefix)
        //{
        //    var node = _root;
        //    var index = 0;
        //    if(_prevValue == null) 
        //        return false;
        //    foreach(char c in prefix)
        //        if(_prevValue[index] != c)
        //            return false;
        //    return true;
        //}
    }
}
