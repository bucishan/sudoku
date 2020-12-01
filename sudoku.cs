using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sudoku
{
    public partial class sudoku : Form
    {
        public sudoku()
        {
            InitializeComponent();
            pSudoku.Width = pSudoku.Height;
        }

        /// <summary>
        /// 调整面板大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sudoku_Resize(object sender, EventArgs e)
        {
            pSudoku.Width = pSudoku.Height;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            pSudoku.Invalidate();
        }

        /// <summary>
        /// 绘制数独九宫格
        /// </summary>
        private void pSudoku_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SetGDIHigh();
            g.Clear(Color.White);

            Rectangle rect = pSudoku.ClientRectangle;
            rect.Inflate(-10, -10);


            //计算并绘制宫格
            int spacing = rect.Width / 9;

            int size = spacing * 9;


            //绘制行列
            for (int i = 0; i < 10; i++)
            {
                Pen pen = (i % 3 == 0) ? new Pen(Color.Black, 3) : Pens.Black;

                //行
                g.DrawLine(pen, rect.X, rect.Y + (i * spacing), rect.X + size, rect.Y + (i * spacing));

                //列
                g.DrawLine(pen, rect.X + (i * spacing), rect.Y, rect.X + (i * spacing), rect.Y + size);
            }

        }

    }
}
