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

        
        

    }
}
