using System;

namespace L173___Binary_Trees
{
    internal class Program
    {

        // Alternatively, using parallel arrays
        static int[] lefts = new int[10];
        static string[] data = new string[10];
        static int[] rights = new int[10];

        // Alternatively, using OOP

        class Node2
        {
            private string data;
            private Node2 left;
            private Node2 right;

            public Node2(string d)
            {
                data = d;
            }
            public void AddLeftChild(Node2 child)
            {
                left = child;
            }
            public void AddRightChild(Node2 child)
            {
                right = child;
            }

            public Node2 GetLeft() { return left; }
            public Node2 GetRight() { return right; }
            public string GetData() { return data; }
        }

        static Node2 TreeRoot;

        struct Node
        {
            public int left;
            public int right;
            public string data;
        }

        static Node[] penguinTree = new Node[10];
        static int numNodes = 1;

        static void AddNode(Node n)
        {
            penguinTree[numNodes] = n;
            numNodes++;
        }

        static void PreOrderTraversal(int currentNode)
        {
            // Visit node
            Console.WriteLine(penguinTree[currentNode].data);
            // Traverse left subtree (if it exists)
            if (penguinTree[currentNode].left != 0)
            {
                PreOrderTraversal(penguinTree[currentNode].left);
            }
            // Traverse right subtree (if it exists)
            if (penguinTree[currentNode].right != 0)
            {
                PreOrderTraversal(penguinTree[currentNode].right);
            }
        }

        static void InOrderTraversal(int currentNode)
        {
            
            // Traverse left subtree (if it exists)
            if (penguinTree[currentNode].left != 0)
            {
                InOrderTraversal(penguinTree[currentNode].left);
            }
            // Visit node
            Console.WriteLine(penguinTree[currentNode].data);
            // Traverse right subtree (if it exists)
            if (penguinTree[currentNode].right != 0)
            {
                InOrderTraversal(penguinTree[currentNode].right);
            }
        }


        static void InsertNode(Node2 node, string data)
        {
            if (node.GetData().CompareTo(data) > 0)
            {
                // insert left
                if (node.GetLeft() != null)
                {
                    // Recurse
                    InsertNode(node.GetLeft(), data);
                } else
                {
                    node.AddLeftChild(new Node2(data));
                }
            } else
            {
                // insert right
                if (node.GetRight() != null)
                {
                    // Recurse
                    InsertNode(node.GetRight(), data);
                }
                else
                {
                    node.AddRightChild(new Node2(data));
                }
            }
        }

        static void InOrder(Node2 node)
        {
            if (node.GetLeft() != null)
            {
                InOrder(node.GetLeft());
            }
            Console.WriteLine(node.GetData());
            if (node.GetRight() != null)
            {
                InOrder(node.GetRight());
            }
        }

        static void Main(string[] args)
        {
            TreeRoot = new Node2("Humboldt");

            InsertNode(TreeRoot, "Adelie");
            InsertNode(TreeRoot, "Emperor");
            InsertNode(TreeRoot, "African");
            InsertNode(TreeRoot, "Macaroni");
            InsertNode(TreeRoot, "Snares");
            InsertNode(TreeRoot, "Fairy");
            InsertNode(TreeRoot, "King");

            InOrder(TreeRoot);

            //AddNode(new Node() { left = 2, right = 5, data = "Humboldt" });
            //AddNode(new Node() { left = 0, right = 3, data = "Adelie" });
            //AddNode(new Node() { left = 4, right = 7, data = "Emperor" });
            //AddNode(new Node() { left = 0, right = 0, data = "African" });
            //AddNode(new Node() { left = 8, right = 6, data = "Macaroni" });
            //AddNode(new Node() { left = 0, right = 0, data = "Snares" });
            //AddNode(new Node() { left = 0, right = 0, data = "Fairy" });
            //AddNode(new Node() { left = 0, right = 0, data = "King" });

            //InOrderTraversal(1);

            Console.ReadKey();
        }
    }
}
