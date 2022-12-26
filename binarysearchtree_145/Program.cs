using System;

namespace BinarySearchTree
{
    class program
    {
        /* A node class const 
         



        */

        class node
        {
            public string info;
            public node lchidl;
            public node rchild;

            //constructor for the node class

            public node(string i, node l, node r )
            {
                info = i;
                lchild = l;
                rchild = r;
            }
        }
    }
}