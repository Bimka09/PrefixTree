namespace PrefixTree
{
    public class NodeGen<T>
    {
        public NodeGen<T>[] child;
        public T? value;
        const int _alphabet = 128;

        public NodeGen()
        {
            child = new NodeGen<T>[_alphabet];
            value = default(T);
        }

        public NodeGen<T> Add(char c)
        {

            child[c] = new NodeGen<T>(); 
            return child[c];
        }
    }
}
