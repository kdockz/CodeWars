using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleSolver
{
    class Board
    {
        private class Node
        {
            public char Letter { get; set; }
            public List<Node> m_Neighbors = new List<Node>();
            public bool Visited { get; set; }
        }

        // structs make copies 
        // classes reference pointers
        //struct NodeStruct
        //{
        //    public char Letter { get; set; }
        //    public List<NodeStruct> m_Neighbors;
        //}
        
       //Class property for board size
        private int m_BoardSize;
        private Node[,] Layout { get; set; } //public Node[,] Layout { get; set; }
        private Dictionary<string, int> m_Words;
        private Webster m_Dic = new Webster("D:\\words.txt");
        private const int MINIMUM_WORD_LENGTH = 3;

        public Board(int size)
        {     
            m_BoardSize = size;
            Layout = new Node[size, size];

            CreateLayout();
            BuildNeighbors();
        }

        public char GetLetter(int x, int y)
        {
            return Layout[x, y].Letter;
        }

        private void CreateLayout()
        {
            Random rnd = new Random();

            for (int x = 0; x < m_BoardSize; x++)
            {
                for (int y = 0; y < m_BoardSize; y++)
                {
                    var node = new Node();
                    int letter = rnd.Next((int)'a', (int)'z');

                    node.Letter = (char)letter;
                    Layout[x, y] = node;
                }
            }
        }

        private void BuildNeighbors()
        {
            for (int x = 0; x < m_BoardSize; x++)
            {
                for (int y = 0; y < m_BoardSize; y++)
                {
                    BuildNeighbors(x, y);
                    Console.WriteLine("Found {0} neighbors for ({1}, {2})", Layout[x, y].m_Neighbors.Count, x, y);
                }
            }
        }

        private void BuildNeighbors(int x, int y)
        {
            //if (x == row) && (y == col) { }
            //if (!((x == row) && (y == col))) { }
            //if (!(x == row) || !(y == col)) { }
            //if ((x != row) || (y != col)) { }

            //Node cur = Layout[x, y];
            Console.WriteLine("Building neighbors for ({0}, {1})", x, y); 

            for (int row = x - 1; row <= x + 1; row++)
            {
                for (int col = y - 1; col <= y + 1; col++)
                {
                    //if (IsValid(row, col) && (Layout[row, col] != cur))
                    if (IsValid(row, col) && ((x != row) || (y != col)))
                    {
                        Layout[x, y].m_Neighbors.Add(Layout[row, col]);
                    }
                }
            }
        }

        private bool IsValid(int x, int y)
        {
            return (InSizeRange(x) && InSizeRange(y));
        }

        private bool InSizeRange(int index)
        {
            return ((index >= 0) && (index < m_BoardSize));
        }

        public Dictionary<string, int> Solve()
        {
            if (m_Words != null)
            {
                return m_Words;
            }

            m_Words = new Dictionary<string, int>();

            foreach (var node in Layout)
            {
                string word = "";
                Solve(word, node);
            }

            return m_Words;
        }

        private void Solve(string word, Node node)
        {
            word += node.Letter;
            node.Visited = true;

            if ((word.Length >= MINIMUM_WORD_LENGTH) & (m_Dic.IsWord(word)))
            {
                if (m_Words.ContainsKey(word))
                {
                    m_Words[word] += 1;
                }
                else
                {
                    m_Words.Add(word, 1);
                }
            }

            if (m_Dic.IsPrefix(word))
            {
                foreach (var neighbor in node.m_Neighbors)
                {
                    if (!neighbor.Visited)
                    {
                        Solve(word, neighbor);
                    }
                }
            }

            node.Visited = false;
        }
    }
}
