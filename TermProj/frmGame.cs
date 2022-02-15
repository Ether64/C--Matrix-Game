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
    public partial class frmGame : Form
    {
        List<Game> History;
        Game game;
        Button[,] Grid;
        Timer gameTimer;
        bool isFirstTime = true;
        public frmGame()
        {
            InitializeComponent();
            History = new List<Game>();
        }
       
        private void frmGame_Load(object sender, EventArgs e)
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
           /* if(tbPlayerName.Text.Length == 0 || tbGameName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter a Player Name and Game Name Before Starting","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }*/
            if(tbPlayerName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter a Player Name Before Starting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            isFirstTime = true;
            game = new Game();
            game.PlayerName = tbPlayerName.Text;
            //game.GameName = tbGameName.Text;
            //label1.Text = game.GameName;
            
            InitializeGrid();
            game.Initialize();
            SetFirstValue(game.StartIndex);
            EnableGameButtons();
            btnStart.Enabled = false;
            gameTimer.Start();
        }
        private void gridBtn_Click(object sender, EventArgs e)  //method that executes for each click of a button on 5x5 array
        {
            ResumeGame();

            if (isFirstTime)
            {
                game.BeginDate = DateTime.Now;
                isFirstTime = false;
            }

            Button btn = sender as Button;
            Index i = btn.Tag as Index;

            if (game.Proceed(i))
            {
                // update value of same button
                btn.Text = game.Predecessor.ToString();
                btn.Enabled = false;
            }
            else
            {
                ShowGameError();
            }
            // if game is finished then display success message
            if (game.IsWon)
            {
                GameOverMessage("Congratulations! You WON!!! \nDo you want to Play Again Or Quit Application (Cancel)?", sender, e);
            }
            else if (game.IsLost)
            {
                GameOverMessage("You LOST! \nDo you want to Play Again Or Quit Application (Cancel)?", sender, e);
            }
        }
        private void btnRevert_Click(object sender, EventArgs e)
        {
            ResumeGame();
            // get current path
            Index lastValueIndex = game.PredecessorIndex;
            // try to revert
            if (game.Revert())
            {
                // make button text clear
                Grid[lastValueIndex.X, lastValueIndex.Y].Text = "";
                // make button usable
                Grid[lastValueIndex.X, lastValueIndex.Y].Enabled = true;
            }
            else
            {
                ShowGameError();
            }
        }
        private void btnAbort_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Are you sure you want to abort ? the current progress will be lost",
                    "Abort",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes
                )
            {
                // before aborting , save the game in history
                History.Add(game);
                game.BeginDate = DateTime.Now;
                gameTimer.Stop();
                lblGameTime.Text = "00:00:00";
                tbPlayerName.Clear();
                DisableGameButtons();
                flpGamePanel.Controls.Clear();
              
               // game = new Game();
            }

        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            game.GameplayTime++;
            lblGameTime.Text = GetFormattedTime(game.GameplayTime);
        }
        private void btnShowSolution_Click(object sender, EventArgs e)
        {
            if (
                 MessageBox.Show(
                    "Are you sure you want to show the solution? The current game will be aborted.",
                    "Show Solution",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes
                 )
            {
                History.Add(game);
                game.BeginDate = DateTime.Now;
                DisableGameButtons();
                flpGamePanel.Controls.Clear();
                var solution = new GameSolver().Solve(game.StartIndex);
                // display solution in a new form
                new frmSolution(solution).ShowDialog(this);
            }
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            new frmGameHistory(History).ShowDialog(this);
        }

        private void flpGamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                History.Add(game);

                game.BeginDate = DateTime.Now;
                gameTimer.Stop();
                lblGameTime.Text = "00:00:00";
                tbPlayerName.Clear();
                //DisableGameButtons();
                flpGamePanel.Controls.Clear();
                game = new Game();
               
            }
            Application.Exit();
        }

        private void btnNew_Click(object sender, EventArgs e) //aborts current game, starts another
        {
            //abort iterations
            History.Add(game);
            game.BeginDate = DateTime.Now;
            gameTimer.Stop();
            lblGameTime.Text = "00:00:00";
            //tbPlayerName.Clear();
            DisableGameButtons();
            flpGamePanel.Controls.Clear();
            game = new Game();

            //start iterations
            game = new Game();
            game.PlayerName = tbPlayerName.Text;
            //game.GameName = tbGameName.Text;
            //label1.Text = game.GameName;

            InitializeGrid();
            game.Initialize();
            SetFirstValue(game.StartIndex);
            EnableGameButtons();
            btnStart.Enabled = false;
            gameTimer.Start();
        }
    }
}
