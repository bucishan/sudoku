namespace sudoku
{
    partial class sudoku
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pSudoku = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pSudoku
            // 
            this.pSudoku.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSudoku.Location = new System.Drawing.Point(0, 0);
            this.pSudoku.Name = "pSudoku";
            this.pSudoku.Size = new System.Drawing.Size(350, 446);
            this.pSudoku.TabIndex = 0;
            this.pSudoku.Paint += new System.Windows.Forms.PaintEventHandler(this.pSudoku_Paint);
            // 
            // sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 446);
            this.Controls.Add(this.pSudoku);
            this.Name = "sudoku";
            this.Text = "数独九宫格计算";
            this.Resize += new System.EventHandler(this.sudoku_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSudoku;
    }
}

