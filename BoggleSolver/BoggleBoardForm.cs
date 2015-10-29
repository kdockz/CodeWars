using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoggleSolver
{
    public partial class frmBoggleBoardSolver : Form
    {

        //Class property for board size
        private int m_BoardSize;
        private Board m_Board;


        public frmBoggleBoardSolver()
        {
            InitializeComponent();
        }


        private void txtBoardSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBoardSize_Click(object sender, EventArgs e)
        {

        }

        private void GenerateTable()
        {
            //Clear out the existing controls, we are generating a new table layout
            tlpBoard.Controls.Clear();

            //Clear out the existing row and column styles
            tlpBoard.ColumnStyles.Clear();
            tlpBoard.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            tlpBoard.ColumnCount = m_BoardSize;
            tlpBoard.RowCount = m_BoardSize;

            for (int x = 0; x < m_BoardSize; x++)
            {
                //First add a column
                tlpBoard.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < m_BoardSize; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    if (x == 0)
                    {
                        tlpBoard.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    //Create the control, in this case we will add a button
                    Label lblIndex = new Label();
                    //var node = m_Board.Layout[x, y];
                    //lblIndex.Text = node.Letter; //String.Format("({0}, {1})", x, y);         //Finally, add the control to the correct location in the table
                    lblIndex.Text = m_Board.GetLetter(x, y).ToString() + String.Format("({0}, {1})", x, y);
                    tlpBoard.Controls.Add(lblIndex, x, y);
                }
            }

            tlpBoard.Visible = true;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            m_BoardSize = Int32.Parse(txtBoardSize.Text);

            if (Int32.TryParse(txtBoardSize.Text, out m_BoardSize))
            {
                Console.WriteLine("Board size will be " + m_BoardSize);
            }
            else
            {
                Console.WriteLine("Board could not be built.");
            }

            m_Board = new Board(m_BoardSize);

            GenerateTable();


        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> words = m_Board.Solve();

            Console.WriteLine("Found " + words.Count + " words.");

            foreach (var word in words)
            {
                Console.WriteLine(word.Key + " - " + word.Value);
            }
        }
    }
}
