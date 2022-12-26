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

            public void postorder(node ptr)
            {
                if (ROOT == null)
                {
                    Console.WriteLine("Tree is empty"); 
                    return;
                }
                if(ptr != null)
                {
                    postorder(ptr.lchid);
                    postorder(ptr.rchild);
                    Console.Write(ptr.info + "");
                }
            }
        }

        static void main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implement Insert Operation");
                Console.WriteLine("2. perform inorder traversal");
                Console.WriteLine("3. perform peorder traversal");
                Console.WriteLine("4. perform postorder traversal");
                Console.WriteLine("5. Exit ");
                Console.WriteLine("\nEnter your choice (1-5 :");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.WriteLine("Enter a word : ");
                            string word = Console.ReadLine();
                            x.insert(word);
                        }
                        break;
                    case '2':
                        {
                            x.inorder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.preorder(x.ROOT);
                        }
                        break;
                    case '4':
                        {
                            x.postorder(x.ROOT);
                        }
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid Option");
                            break;
                        }

                }
            }
        }
    }
}