/*
Given an array of string sorted by a pattern.
Return the sorting pattern string.
Ex. give you
{foo, cat, cao, bag, bat, aac}
return: fcbagto

further: how do you detect some words are out of order.
*/

namespace TWT
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public class GraphTWT
    {
        private Dictionary<char, DirectedGraphNode> nodes;

        public GraphTWT()
        {
            this.nodes = new Dictionary<char, DirectedGraphNode>();
        }

        public string SortPattern(List<string> words)
        {
            if (words.Count == 0)
                return string.Empty;

            for (int i = 0; i < words.Count - 1; i++)
            {
                string w1 = words[i];
                string w2 = words[i + 1];
                int len = Math.Min(w1.Length, w2.Length);
                for (int j = 0; j < len; j++)
                {
                    if (w1[j] != w2[j])
                    {
                        this.AddEdge(w1[j], w2[j]);
                        break;
                    }
                }
            }

            return this.TopologicalSort();
        }

        private string TopologicalSort()
        {
            Stack<char> stk = new Stack<char>();
            bool[] visited = new bool[26];
            bool[] recStack = new bool[26];

            foreach(DirectedGraphNode d in this.nodes.Values)
            {
                if (visited[d.Label - 'a'] == false)
                {
                    bool cyclic = this.TopologicalSortUtil(d, visited, recStack, stk);
                    if (cyclic == true)
                        return "invalid";
                }
            }

            StringBuilder sb = new StringBuilder();
            while(stk.Count > 0)
                sb.Append(stk.Pop());

            return sb.ToString();
        }

        // true if cyclic
        private bool TopologicalSortUtil(
            DirectedGraphNode node, bool[] visited, bool[] recStack, Stack<char> stk)
        {
            visited[node.Label - 'a'] = true;
            recStack[node.Label - 'a'] = true;

            foreach (DirectedGraphNode d in node.Neighbors)
            {
                if (visited[d.Label - 'a'] == false &&
                    TopologicalSortUtil(d, visited, recStack, stk))
                    return true;
                else if (recStack[d.Label - 'a'] == true)
                    return true;
            }

            recStack[node.Label - 'a'] = false;
            stk.Push(node.Label);
            return false;
        }

        private void AddEdge(char a, char b)
        {
            if (!this.nodes.ContainsKey(a))
                this.nodes.Add(a, new DirectedGraphNode(a));

            if (!this.nodes.ContainsKey(b))
                this.nodes.Add(b, new DirectedGraphNode(b));

            if(!this.nodes[a].Neighbors.Contains(this.nodes[b]))
                this.nodes[a].Neighbors.Add(this.nodes[b]);
        }
    }

    public class DirectedGraphNode
    {
        public char Label { get; set; }
        public List<DirectedGraphNode> Neighbors { get; set; }

        public DirectedGraphNode(char x)
        {
            this.Label = x;
            this.Neighbors = new List<DirectedGraphNode>();
        }
    };
}