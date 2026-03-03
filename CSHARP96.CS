using System;
using System.Collections.Generic;

class TrieNode
{
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool IsEnd;
}

class Program
{
    static TrieNode root = new TrieNode();

    static void Insert(string word)
    {
        var node = root;
        foreach (char c in word)
        {
            if (!node.Children.ContainsKey(c))
                node.Children[c] = new TrieNode();
            node = node.Children[c];
        }
        node.IsEnd = true;
    }

    static bool Search(string word)
    {
        var node = root;
        foreach (char c in word)
        {
            if (!node.Children.ContainsKey(c))
                return false;
            node = node.Children[c];
        }
        return node.IsEnd;
    }

    static void Main()
    {
        Insert("data");
        Insert("structure");
        Console.WriteLine(Search("data"));
    }
}