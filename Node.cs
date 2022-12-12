namespace IEnumeralble
{
    internal class Node<t>
    {
        //make node class for linked lists
        private t data;
        private Node<t>? next;
        //make properties for the fields
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
