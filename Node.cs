namespace IEnumeralble
{
    internal class Node<t>
    {
        
        private t data;
        private Node<t>? next;
        public t Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<t> Next
        {
            get { return next; }
            set { next = value; }
        }
        
        public Node(t data)
        {
            this.data = data;
            this.next = null;
        }

    }
}
