using System;
using System.Collections.Generic;

namespace DepthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();
        public Node(string name)
        {
            this.name = name;
        }

    }
    public Node AddChild(string name)
    {
        Node Child = new Node(name);
        children.Add(Child);
        return this;
    } 
    public List<string> DepthFirst(List<string> names)
    {
        names.Add(this.name);
        for(var i = 0; i < children.Count; i++)
        {
            children[i].DepthFirst(names);
        }
    }
    
}
