using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BoggleSolver
{
    class Webster
    {
        private class Node 
        {
            //public char Letter  { get; set; }
            public Dictionary<char, Node> m_Children = new Dictionary<char, Node>();
            public bool IsEndOfWord { get; set; }
        }

        //Class member for dictionary
        private Node m_Words = new Node();
        private const string PATTERN = "^[a-zA-Z]+(\\-?[a-zA-Z]+)*$";

        public Webster(string file)
        {
            var words = System.IO.File.ReadAllText(file).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (IsValidWord(word))
                {
                    var cur = m_Words;
                    foreach (var letter in word.ToLower())
                    {
                        if (!cur.m_Children.ContainsKey(letter))
                        {
                            Node letterNode = new Node();
                            cur.m_Children.Add(letter, letterNode);
                            //cur = letterNode;
                        }

                        cur = cur.m_Children[letter];
                    }

                    cur.IsEndOfWord = true;  
                }
            }
        }

        private static bool IsValidWord(string value)
        {
            return Regex.IsMatch(value, PATTERN);
        }

        public bool IsWord(string word)
        {
            var cur = m_Words;

            foreach (var letter in word)
            {
                if (!cur.m_Children.ContainsKey(letter))
                {
                    return false;
                }

                cur = cur.m_Children[letter];
            }

            return cur.IsEndOfWord;
        }

        public bool IsPrefix(string word)
        {
            var cur = m_Words;

            foreach (var letter in word)
            {
                if (!cur.m_Children.ContainsKey(letter))
                {
                    return false;
                }

                cur = cur.m_Children[letter];
            }

            return true;
        }
    }
}
