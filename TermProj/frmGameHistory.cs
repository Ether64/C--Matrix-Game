using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.Json;

namespace TermProj
{
    public partial class frmGameHistory : Form
    {
         readonly List<Game> games;
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string GameName { get; set; }
        public string GameBegin { get; set; }
        public string PlayTime { get; set; }

        public static int firstClick = 2;
        public frmGameHistory()
        {
            InitializeComponent();
        }

        public frmGameHistory(List<Game> games)
            :this()
        {
            this.games = games;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            //dgvData.Rows.Add(i, games[i].BeginDate.ToShortDateString());
            // TODO: This line of code loads data into the 'hIstoryDataSet.HistoryData' table. You can move, or remove it, as needed.
           // bindingNavigatorAddNewItem.PerformClick();
            this.historyDataTableAdapter.Fill(this.hIstoryDataSet.HistoryData);
        
            for (int i = 0; i < games.Count; i++)
            {
                dgvData.Rows.Add(i, games[i].BeginDate.ToShortDateString());
            }
        }

        public void btnShowHistory_Click(object sender, EventArgs e)
        {
            if (firstClick == 2)
            {
                bindingNavigatorAddNewItem.PerformClick();
                firstClick--;
                //MessageBox.Show("value of firstClick: {0}", Convert.ToString(firstClick));
            } 
            //MessageBox.Show("value of firstClick: {0}", Convert.ToString(firstClick));

            if (dgvData.Rows.Count > 0)
            {
                if (dgvData.CurrentRow != null)
                {
                    int index = int.Parse(dgvData.CurrentRow.Cells[0].Value.ToString());
                    var game = games[index];

                    lblGameBegin.Text = game.BeginDate.ToString();
                    //gameBeginTextBox.Text = lblGameBegin.Text;
                    lblGameName.Text = $"Game {index + 1}";
                    //gameNameTextBox.Text = lblGameName.Text;
                    lblPlayerName.Text = game.PlayerName;
                    //_PlayerNameTextBox.Text = lblPlayerName.Text;
                    TimeSpan t = TimeSpan.FromSeconds(game.GameplayTime);

                    lblPlayTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}",
                       t.Hours,
                       t.Minutes,
                       t.Seconds
                      );
                    // this.tableAdapterManager.InitializeLifetimeService
                    //playTimeTextBox.Text = lblPlayTime.Text;
                    //historyDataBindingNavigatorSaveItem_Click(object sender, EventArgs e);

                }
                 } 
            //bindingNavigatorAddNewItem.PerformClick();
        }

        

        public void SerializeGameHistory(object sender, EventArgs e) 
        {
            //lblGame
        }

        public void deSerializeGameHistory(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblGameBegin_Click(object sender, EventArgs e)
        {

        }

        private void lblGameName_Click(object sender, EventArgs e)
        {

        }

        private void btnHistories_Click(object sender, EventArgs e)
        {

        }

        private void historyDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hIstoryDataSet);

            try
            {
                historyDataTableAdapter.Insert(
                    this.Id,
                    this.lblPlayerName.Text,
                    this.lblGameName.Text,
                    this.lblGameBegin.Text,
                    this.lblPlayTime.Text);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("identical data input");
            }

        }

        private void historyDataBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void historyDataBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //this.tableAdapterManager.UpdateAll(this.hIstoryDataSet);
            //MessageBox.Show("add button clicked", "addbuttonpress");
        }

        private void historyDataDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
