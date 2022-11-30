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
                linkedList.Append(56);
                linkedList.Append(30);
                linkedList.Append(70);
                linkedList.Display();
                Console.ReadLine();
        }
    }
}
