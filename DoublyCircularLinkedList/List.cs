using System;
namespace DataStructure
{
    internal class Linkedlist
    {
        private Node headNode;

        public  Linkedlist()
        {
            headNode = new Node();
            headNode.Prev= headNode;
            headNode.Next = headNode;
        }

        public void insertAtBegin(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode, newNode, headNode.Next);
        }

        public void insertAtEnd(int data)
        {
            Node newNode = new Node(data);
            GenericInsert(headNode.Prev, newNode,headNode);
        }

        public void insertAtPos(int data,int pos)
        {
            Node newNode = new Node(data);
            int count = 1;
            Node tempNode = headNode.Next;
            while(count<pos && tempNode.Next!= headNode)
            {
                count++;
                tempNode = tempNode.Next;
            }
            GenericInsert(tempNode.Prev,newNode,tempNode);
        }

        public void insertAfter(int data, int after)
        {
            Node newNode = new Node(data);
            Node tempNode = headNode.Next;
            while(tempNode.Data != after && tempNode!=headNode)
            {
                tempNode = tempNode.Next;
            }
            GenericInsert(tempNode, newNode, tempNode.Next);

        }

        public int removeAtBegin()
        {
            int removedData;
            removedData = headNode.Next.Data;
            GenericRemove(headNode.Next);
            return removedData;
        }

        public int removeAtEnd()
        {
            if(headNode.Prev == headNode)
            {
                return -1;
            }

            int removedData;
            removedData = headNode.Prev.Data;
            GenericRemove(headNode.Prev);
            return removedData;
        }
        public int removeData(int data)
        {
            if(headNode.Next == headNode)
            {
                return -1;
            }
            Node tempNode = headNode.Next;
            int removedData;
            removedData = tempNode.Data;
            while(tempNode.Data != data && tempNode != headNode)
            {
                tempNode = tempNode.Next; 
            }
            GenericRemove(tempNode);
            return removedData;
        }
        public int length()
        {
            int length = 0;
            Node tempNode = headNode.Next;
            while(tempNode != headNode)
            {
                length++;
                tempNode = tempNode.Next;
            }
            return length;
        }

        public bool find(int data)
        {
            Node tempNode = headNode.Next;
            while(tempNode != headNode )
            {
                if(tempNode.Data == data)
                {
                    return true;
                }
                tempNode = tempNode.Next;
            }
            return false;
        }

        public static void GenericInsert(Node start,Node mid,Node end)
        {
            start.Next = mid;
            mid.Next = end;
            end.Prev = mid;
            mid.Prev = start;
        }

        public static void GenericRemove(Node deleteNode)
        {
            deleteNode.Next.Prev = deleteNode.Prev;
            deleteNode.Prev.Next = deleteNode.Next;
        }
        public void print()
        {
            Node tempNode = headNode.Next;
            while(tempNode != headNode)
            {
                Console.Write(tempNode.Data + " ");
                tempNode = tempNode.Next;
            }
            Console.WriteLine("End");
        }
    }
}