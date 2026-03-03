using System;

class AVL
{
    class Node
    {
        public int key, height;
        public Node left, right;
        public Node(int k) { key = k; height = 1; }
    }

    static int Height(Node n) => n == null ? 0 : n.height;

    static Node RightRotate(Node y)
    {
        Node x = y.left;
        Node T2 = x.right;
        x.right = y;
        y.left = T2;
        y.height = Math.Max(Height(y.left), Height(y.right)) + 1;
        x.height = Math.Max(Height(x.left), Height(x.right)) + 1;
        return x;
    }

    static Node LeftRotate(Node x)
    {
        Node y = x.right;
        Node T2 = y.left;
        y.left = x;
        x.right = T2;
        x.height = Math.Max(Height(x.left), Height(x.right)) + 1;
        y.height = Math.Max(Height(y.left), Height(y.right)) + 1;
        return y;
    }

    static int GetBalance(Node n) => n == null ? 0 : Height(n.left) - Height(n.right);

    static Node Insert(Node node, int key)
    {
        if (node == null) return new Node(key);

        if (key < node.key) node.left = Insert(node.left, key);
        else if (key > node.key) node.right = Insert(node.right, key);
        else return node;

        node.height = 1 + Math.Max(Height(node.left), Height(node.right));

        int balance = GetBalance(node);

        if (balance > 1 && key < node.left.key)
            return RightRotate(node);

        if (balance < -1 && key > node.right.key)
            return LeftRotate(node);

        if (balance > 1 && key > node.left.key)
        {
            node.left = LeftRotate(node.left);
            return RightRotate(node);
        }

        if (balance < -1 && key < node.right.key)
        {
            node.right = RightRotate(node.right);
            return LeftRotate(node);
        }

        return node;
    }

    static void Main()
    {
        Node root = null;
        root = Insert(root, 10);
        root = Insert(root, 20);
        root = Insert(root, 30);
        Console.WriteLine(root.key);
    }
}