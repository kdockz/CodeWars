namespace BoggleSolver
{
    partial class frmBoggleBoardSolver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtBoardSize = new System.Windows.Forms.TextBox();
            this.lblBoardSize = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Button();
            this.tlpBoard = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(363, 57);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtBoardSize
            // 
            this.txtBoardSize.Location = new System.Drawing.Point(290, 31);
            this.txtBoardSize.Name = "txtBoardSize";
            this.txtBoardSize.Size = new System.Drawing.Size(100, 20);
            this.txtBoardSize.TabIndex = 3;
            this.txtBoardSize.TextChanged += new System.EventHandler(this.txtBoardSize_TextChanged);
            // 
            // lblBoardSize
            // 
            this.lblBoardSize.AutoSize = true;
            this.lblBoardSize.Location = new System.Drawing.Point(243, 9);
            this.lblBoardSize.Name = "lblBoardSize";
            this.lblBoardSize.Size = new System.Drawing.Size(199, 13);
            this.lblBoardSize.TabIndex = 4;
            this.lblBoardSize.Text = "Enter a number to generate a board size:";
            this.lblBoardSize.Click += new System.EventHandler(this.lblBoardSize_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(246, 57);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 5;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // tlpBoard
            // 
            this.tlpBoard.AutoSize = true;
            this.tlpBoard.BackColor = System.Drawing.Color.Silver;
            this.tlpBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBoard.ColumnCount = 2;
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBoard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpBoard.Location = new System.Drawing.Point(25, 86);
            this.tlpBoard.Name = "tlpBoard";
            this.tlpBoard.RowCount = 2;
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBoard.Size = new System.Drawing.Size(323, 234);
            this.tlpBoard.TabIndex = 6;
            this.tlpBoard.Visible = false;
            // 
            // frmBoggleBoardSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(967, 648);
            this.Controls.Add(this.tlpBoard);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.lblBoardSize);
            this.Controls.Add(this.txtBoardSize);
            this.Controls.Add(this.btnSolve);
            this.Name = "frmBoggleBoardSolver";
            this.Text = "Boggle Board Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtBoardSize;
        private System.Windows.Forms.Label lblBoardSize;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TableLayoutPanel tlpBoard;
    }
}

