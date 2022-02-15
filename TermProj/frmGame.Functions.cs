using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TermProj
{
    partial class frmGame
    {

        private void InitializeGrid()
        {
            flpGamePanel.Controls.Clear();
          //  game = new Game();
            Grid = new Button[game.Rows, game.Cols];

            for (int i = 0; i < game.Rows; i++)
            {
                for (int j = 0; j < game.Cols; j++)
                {
                    Button btn = new Button();
                    btn.Size = new System.Drawing.Size(55, 55);
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.Click += gridBtn_Click;
                    btn.BackColor = Color.White;
                    Grid[i, j] = btn;
                    flpGamePanel.Controls.Add(btn);
                    btn.Tag = new Index(i, j);
                }
            }
        }
        private void EnableGameButtons()
        {
            btnStart.Enabled = true;
            btnAbort.Enabled = true;
            btnRevert.Enabled = true;
            btnNew.Enabled = true;
        }
        public void SetFirstValue(Index i)
        {
            Grid[i.X, i.Y].Text = "1";
            Grid[i.X, i.Y].ForeColor = Color.Red;
            Grid[i.X, i.Y].Enabled = false;
        }
        private void ShowGameError()
        {
            MessageBox.Show(game.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private string GetFormattedTime(int seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
             return string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds
               );
        }
        private void ResumeGame()
        {
            gameTimer.Start();
        }
        private void DisableGameButtons()
        {
            btnStart.Enabled = true;
            btnAbort.Enabled = false;
            btnRevert.Enabled = false;
            btnNew.Enabled = false;
        }
        private void GameOverMessage(string message, object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(message, "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                History.Add(game);
                btnStart_Click(sender, e);
            }
            else
            {
                Application.Exit();
            }
        }

    }

}
