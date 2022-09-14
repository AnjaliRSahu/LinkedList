using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeProblem
{
    public class CustomLinkedList
    {
        public Node head;
        
        //Adding elements to linked list using Add method
        public void Add(int data)
        {
            Node node =new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else 
            {
                Node temp=this.head;
                if (temp.next != null)
                { 
                    temp=temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into the list ",node.data);
        
        }
        //Insert Method 
        public void InsertBetween(int data, int position)
        { 
            Node newNode=new Node(data);
            if (position < 1) 
            {
                Console.WriteLine("Position should be greater ");
            }
            if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node tempNode = new Node(data);
                tempNode = this.head;
                while (position > 2)
                {
                    tempNode = tempNode.next;
                    position--;
                }
                newNode.next = tempNode.next;
                tempNode.next = newNode;
            }
        }
        //Display Method
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp=temp.next;
            }
            
        }

        
        

    }
}
