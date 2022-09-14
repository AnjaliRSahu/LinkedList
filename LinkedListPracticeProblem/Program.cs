using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Program");
            CustomLinkedList customLinkedList=new CustomLinkedList();
            customLinkedList.Add(56);
            //customLinkedList.Add(30);
            customLinkedList.Add(70);

            customLinkedList.InsertBetween(30, 2);
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}
