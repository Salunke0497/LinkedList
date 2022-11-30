using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    internal class Node
    {
        public int data;
        public Node next;

        //constructor
        public Node(int data)
        {
            this.data = data;
        }
    }
}
