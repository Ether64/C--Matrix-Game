
namespace TermProj
{
    partial class frmGameHistory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameHistory));
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblGameBegin = new System.Windows.Forms.Label();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.gameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.historyDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historyDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.historyDataDataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hIstoryDataSet = new TermProj.HIstoryDataSet();
            this.historyDataTableAdapter = new TermProj.HIstoryDataSetTableAdapters.HistoryDataTableAdapter();
            this.tableAdapterManager = new TermProj.HIstoryDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataBindingNavigator)).BeginInit();
            this.historyDataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIstoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHistory.Location = new System.Drawing.Point(605, 6);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(121, 23);
            this.btnShowHistory.TabIndex = 1;
            this.btnShowHistory.Text = "Show Details";
            this.btnShowHistory.UseVisualStyleBackColor = true;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game Begin Date/Time:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Play Time:";
            // 
            // lblGameName
            // 
            this.lblGameName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyDataBindingSource, "GameName", true));
            this.lblGameName.Location = new System.Drawing.Point(381, 134);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(218, 18);
            this.lblGameName.TabIndex = 2;
            this.lblGameName.Click += new System.EventHandler(this.lblGameName_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyDataBindingSource, " PlayerName", true));
            this.lblPlayerName.Location = new System.Drawing.Point(381, 103);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(218, 18);
            this.lblPlayerName.TabIndex = 2;
            // 
            // lblGameBegin
            // 
            this.lblGameBegin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameBegin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyDataBindingSource, "GameBegin", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "F"));
            this.lblGameBegin.Location = new System.Drawing.Point(381, 164);
            this.lblGameBegin.Name = "lblGameBegin";
            this.lblGameBegin.Size = new System.Drawing.Size(218, 18);
            this.lblGameBegin.TabIndex = 2;
            this.lblGameBegin.Click += new System.EventHandler(this.lblGameBegin_Click);
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historyDataBindingSource, "PlayTime", true));
            this.lblPlayTime.Location = new System.Drawing.Point(381, 194);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(218, 18);
            this.lblPlayTime.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Game Histories List";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameId,
            this.gameName});
            this.dgvData.Location = new System.Drawing.Point(8, 52);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(212, 328);
            this.dgvData.TabIndex = 17;
            // 
            // gameId
            // 
            this.gameId.HeaderText = "Game Id";
            this.gameId.Name = "gameId";
            this.gameId.ReadOnly = true;
            this.gameId.Visible = false;
            // 
            // gameName
            // 
            this.gameName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gameName.FillWeight = 400F;
            this.gameName.HeaderText = "Games";
            this.gameName.Name = "gameName";
            this.gameName.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select a game from the list, then click \'Show Details\'";
            // 
            // historyDataBindingNavigator
            // 
            this.historyDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.historyDataBindingNavigator.BindingSource = this.historyDataBindingSource;
            this.historyDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.historyDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.historyDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.historyDataBindingNavigatorSaveItem});
            this.historyDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.historyDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.historyDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.historyDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.historyDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.historyDataBindingNavigator.Name = "historyDataBindingNavigator";
            this.historyDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.historyDataBindingNavigator.Size = new System.Drawing.Size(844, 25);
            this.historyDataBindingNavigator.TabIndex = 21;
            this.historyDataBindingNavigator.Text = "bindingNavigator1";
            this.historyDataBindingNavigator.RefreshItems += new System.EventHandler(this.historyDataBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // historyDataBindingNavigatorSaveItem
            // 
            this.historyDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.historyDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("historyDataBindingNavigatorSaveItem.Image")));
            this.historyDataBindingNavigatorSaveItem.Name = "historyDataBindingNavigatorSaveItem";
            this.historyDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.historyDataBindingNavigatorSaveItem.Text = "Save Data";
            this.historyDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.historyDataBindingNavigatorSaveItem_Click);
            // 
            // historyDataDataGridView1
            // 
            this.historyDataDataGridView1.AutoGenerateColumns = false;
            this.historyDataDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.historyDataDataGridView1.DataSource = this.historyDataBindingSource;
            this.historyDataDataGridView1.Location = new System.Drawing.Point(263, 233);
            this.historyDataDataGridView1.Name = "historyDataDataGridView1";
            this.historyDataDataGridView1.Size = new System.Drawing.Size(543, 263);
            this.historyDataDataGridView1.TabIndex = 31;
            this.historyDataDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyDataDataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(545, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = "Once a game\'s details are displayed, click the \'Add new\' button above to add to d" +
    "atabase. \r\nClick \'Save Data\' to persistently save history data.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = " PlayerName";
            this.dataGridViewTextBoxColumn6.HeaderText = " PlayerName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GameName";
            this.dataGridViewTextBoxColumn7.HeaderText = "GameName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GameBegin";
            this.dataGridViewTextBoxColumn8.HeaderText = "GameBegin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PlayTime";
            this.dataGridViewTextBoxColumn9.HeaderText = "PlayTime";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // historyDataBindingSource
            // 
            this.historyDataBindingSource.DataMember = "HistoryData";
            this.historyDataBindingSource.DataSource = this.hIstoryDataSet;
            this.historyDataBindingSource.CurrentChanged += new System.EventHandler(this.historyDataBindingSource_CurrentChanged);
            // 
            // hIstoryDataSet
            // 
            this.hIstoryDataSet.DataSetName = "HIstoryDataSet";
            this.hIstoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyDataTableAdapter
            // 
            this.historyDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistoryDataTableAdapter = this.historyDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = TermProj.HIstoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmGameHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 519);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.historyDataDataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGameBegin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.historyDataBindingNavigator);
            this.Name = "frmGameHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataBindingNavigator)).EndInit();
            this.historyDataBindingNavigator.ResumeLayout(false);
            this.historyDataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIstoryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblGameBegin;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
        private System.Windows.Forms.Label label6;
        private HIstoryDataSet hIstoryDataSet;
        private System.Windows.Forms.BindingSource historyDataBindingSource;
        private HIstoryDataSetTableAdapters.HistoryDataTableAdapter historyDataTableAdapter;
        private HIstoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator historyDataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton historyDataBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView historyDataDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label7;
    }
}