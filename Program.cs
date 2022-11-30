using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     class Program
    {
         public static void Main(string[] args)
            {
                LinkedList linkedList = new LinkedList();
                linkedList.reverse(30);
                linkedList.reverse(56);
                linkedList.reverse(70);
                linkedList.Display();
            Console.ReadLine();
        }
    }
}
