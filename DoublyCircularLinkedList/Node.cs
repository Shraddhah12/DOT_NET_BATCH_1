using System;
namespace DataStructure
{
    internal class Node
    {
        private int data;
        private Node prev;
        private Node next;

        public Node()
        {
            data = -1;
            prev = null;
            next = null;
        }
        public Node(int data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
        internal int Data
        {
            get{return data;}
            set{data = value;}
        }
        internal Node Prev{
            get{return prev;}
            set{prev = value;}
        }
        internal Node Next 
        {
            get{return next;}
            set{next = value;}
        }
    }
}