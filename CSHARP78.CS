using System;
using System.Collections.Generic;

class TrieNode
{
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool isEnd;
}

class Trie
{
    static TrieNode root = new TrieNode();

    static void Insert(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            if (!node.children.ContainsKey(c))
                node.children[c] = new TrieNode();
            node = node.children[c];
        }
        node.isEnd = true;
    }

    static bool Search(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            if (!node.children.ContainsKey(c))
                return false;
            node = node.children[c];
        }
        return node.isEnd;
    }

    static void Main()
    {
        Insert("hello");
        Console.WriteLine(Search("hello"));
    }
}