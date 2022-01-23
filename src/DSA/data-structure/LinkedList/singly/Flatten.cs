using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.linked_list.singly
{
    internal class Flatten
    {
        public class List
        {
            Node head; // head of list

            /* Linked list Node */
            public class Node
            {
                public int data;
                public Node right, down;
                public Node(int data)
                {
                    this.data = data;
                    right = null;
                    down = null;
                }
            }
        }


    }
}
