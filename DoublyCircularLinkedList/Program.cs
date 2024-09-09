using System;
using DataStructure;
class MainClass
{
    public static void Main(String[] args)
    {
        Linkedlist ll = new Linkedlist();
        ll.insertAtBegin(10);
        ll.insertAtBegin(20);
        
        ll.insertAtEnd(30);
        ll.insertAtPos(15,2);
        ll.print();
        Console.WriteLine(ll.length());

        Console.WriteLine(ll.find(40));

        ll.removeAtEnd();
        ll.removeAtBegin();
        ll.print();

        // ll.removeData(30);

        // ll.print();
        // Console.WriteLine(ll.length());


        

        // ll.insertAfter(15,10);
        // ll.print();
        // ll.removeAtEnd();
        // ll.print();
    }
}