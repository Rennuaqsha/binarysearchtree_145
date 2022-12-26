using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace BinarySearchTree
{
    class program
    {
        /* A node class const 
         



        */

        class node
        {
            public string info;
            public node lchid;
            public node rchild;

            //constructor for the node class

            public node(string i, node l, node r )
            {
                info = i;
                lchid = l;
                rchild = r;
            }
        }

        class BinaryTree
        {
            public node ROOT;

            public BinaryTree()
            {
                ROOT = null;
            }
            
            public void insert(string element)
            {
                node tmp, parent = null, currentnode = null;
                find(element, ref parent, ref currentnode);
                if (currentnode != null)
                {
                    Console.WriteLine("Duplicate words not allowed");
                    return;
                }
                else //if the specified node is not present// 
                {
                    tmp = new node(element, null, null);
                    if(parent != null)
                    {
                        ROOT = tmp;
                    }

                    else if (string.Compare(element, parent.info) < 0)
                    {
                        if (string.Compare(element, parent.info) < 0)
                            parent.lchid = tmp;
                    }
                    else
                    {
                        parent.lchid = tmp;
                    }
                }  
            }

            public void find(string element, ref node parent, ref node currentnode)
            {
                currentnode = ROOT;
                parent = null; 
                while((currentnode != null) && (currentnode.info != element))
                {
                    parent = currentnode;
                    if(string.Compare(element, currentnode.info) < 0)
                        currentnode = currentnode.lchid;
                    else
                        currentnode = currentnode.lchid;
                }
            }

            public void inorder(node ptr)
            {
                if (ROOT == null)
                {
                    Console.WriteLine("Tree is empty");
                    return;
                }
                if(ptr != null)
                {
                    inorder(ptr.lchid);
                    Console.WriteLine(ptr.info + "");
                    inorder(ptr.lchid);
                }
            }

            public void preorder(node ptr)
            {
                if (ROOT == null)
                {
                    Console.WriteLine("Tree is empty");
                    return;
                }
                if (ptr != null)
                {
                    Console.WriteLine(ptr.info + ""); 
                    preorder(ptr.lchid);
                    preorder(ptr.rchild);
                }
            }
        }
    }
}