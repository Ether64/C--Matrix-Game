using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProj
{
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
        }

        public frmSolution(int[,] grid)
            :this()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Size = new System.Drawing.Size(55, 55);
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.BackColor = Color.White;
                    btn.Text = grid[i, j].ToString();
                   
                    if (grid[i, j] == 1)
                    {
                        btn.ForeColor = Color.Red;
                    }
                    flpPanel.Controls.Add(btn);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
