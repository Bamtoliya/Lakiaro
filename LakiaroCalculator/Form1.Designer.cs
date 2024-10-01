using LakiaroCalculator.Customized_Tool;
using System;

namespace LakiaroCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Reset = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DirtInput = new System.Windows.Forms.NumericUpDown();
            this.RootsInput = new System.Windows.Forms.NumericUpDown();
            this.RockInput = new System.Windows.Forms.NumericUpDown();
            this.PossibleRoots = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.solverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new LakiaroCalculator.Customized_Tool.GridControl();
            this.toggleButton1 = new LakiaroCalculator.Customized_Tool.ToggleButton();
            this.nDirtsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDirtsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRootsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRootsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DirtInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(1042, 1284);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(93, 82);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.UseWaitCursor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(935, 1284);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(99, 82);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(1144, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dirt";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(1144, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rock";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(1144, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Root";
            this.label3.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("굴림", 20F);
            this.label5.Location = new System.Drawing.Point(31, 1271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 40);
            this.label5.TabIndex = 22;
            this.label5.Text = "Recommendation";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("굴림", 20F);
            this.label6.Location = new System.Drawing.Point(667, 1271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 40);
            this.label6.TabIndex = 23;
            this.label6.Text = "Flower";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("굴림", 20F);
            this.label7.Location = new System.Drawing.Point(384, 1271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 40);
            this.label7.TabIndex = 24;
            this.label7.Text = "Possible Root";
            this.label7.UseWaitCursor = true;
            // 
            // DirtInput
            // 
            this.DirtInput.Location = new System.Drawing.Point(1234, 61);
            this.DirtInput.Margin = new System.Windows.Forms.Padding(4);
            this.DirtInput.Name = "DirtInput";
            this.DirtInput.Size = new System.Drawing.Size(67, 28);
            this.DirtInput.TabIndex = 29;
            this.DirtInput.UseWaitCursor = true;
            // 
            // RootsInput
            // 
            this.RootsInput.Location = new System.Drawing.Point(1234, 89);
            this.RootsInput.Margin = new System.Windows.Forms.Padding(4);
            this.RootsInput.Name = "RootsInput";
            this.RootsInput.Size = new System.Drawing.Size(67, 28);
            this.RootsInput.TabIndex = 30;
            this.RootsInput.UseWaitCursor = true;
            // 
            // RockInput
            // 
            this.RockInput.Location = new System.Drawing.Point(1234, 117);
            this.RockInput.Margin = new System.Windows.Forms.Padding(4);
            this.RockInput.Name = "RockInput";
            this.RockInput.Size = new System.Drawing.Size(67, 28);
            this.RockInput.TabIndex = 30;
            this.RockInput.UseWaitCursor = true;
            // 
            // PossibleRoots
            // 
            this.PossibleRoots.AutoSize = true;
            this.PossibleRoots.Font = new System.Drawing.Font("굴림", 20F);
            this.PossibleRoots.Location = new System.Drawing.Point(31, 1311);
            this.PossibleRoots.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PossibleRoots.Name = "PossibleRoots";
            this.PossibleRoots.Size = new System.Drawing.Size(345, 40);
            this.PossibleRoots.TabIndex = 20;
            this.PossibleRoots.Text = "Possible Roots: 0";
            this.PossibleRoots.UseWaitCursor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1300, 117);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 28);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.UseWaitCursor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1300, 89);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 28);
            this.numericUpDown2.TabIndex = 34;
            this.numericUpDown2.UseWaitCursor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(1300, 61);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 28);
            this.numericUpDown3.TabIndex = 33;
            this.numericUpDown3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F);
            this.label4.Location = new System.Drawing.Point(1146, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Provided";
            this.label4.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 20F);
            this.label8.Location = new System.Drawing.Point(1323, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 40);
            this.label8.TabIndex = 15;
            this.label8.Text = "Current";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 30F);
            this.label9.Location = new System.Drawing.Point(92, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 60);
            this.label9.TabIndex = 36;
            this.label9.Text = "Normal";
            this.label9.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 30F);
            this.label10.Location = new System.Drawing.Point(500, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 60);
            this.label10.TabIndex = 37;
            this.label10.Text = "Wild";
            this.label10.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nDirtsDataGridViewTextBoxColumn,
            this.cDirtsDataGridViewTextBoxColumn,
            this.nRootsDataGridViewTextBoxColumn,
            this.cRootsDataGridViewTextBoxColumn,
            this.nRocksDataGridViewTextBoxColumn,
            this.cRocksDataGridViewTextBoxColumn,
            this.levelDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.solverBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 948);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 218);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // solverBindingSource
            // 
            this.solverBindingSource.DataSource = typeof(LakiaroCalculator.Src.Solver);
            // 
            // gridControl1
            // 
            this.gridControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridControl1.Location = new System.Drawing.Point(38, 117);
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.MinimumSize = new System.Drawing.Size(1097, 1152);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1097, 1152);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.UseWaitCursor = true;
            // 
            // toggleButton1
            // 
            this.toggleButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.solverBindingSource, "Level", true));
            this.toggleButton1.Location = new System.Drawing.Point(322, 14);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(64, 33);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Beige;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumAquamarine;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(171, 75);
            this.toggleButton1.TabIndex = 25;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.UseVisualStyleBackColor = true;
            this.toggleButton1.UseWaitCursor = true;
            this.toggleButton1.CheckedChanged += new System.EventHandler(this.toggleButton1_CheckedChanged);
            // 
            // nDirtsDataGridViewTextBoxColumn
            // 
            this.nDirtsDataGridViewTextBoxColumn.DataPropertyName = "NDirts";
            this.nDirtsDataGridViewTextBoxColumn.HeaderText = "NDirts";
            this.nDirtsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nDirtsDataGridViewTextBoxColumn.Name = "nDirtsDataGridViewTextBoxColumn";
            this.nDirtsDataGridViewTextBoxColumn.Width = 150;
            // 
            // cDirtsDataGridViewTextBoxColumn
            // 
            this.cDirtsDataGridViewTextBoxColumn.DataPropertyName = "CDirts";
            this.cDirtsDataGridViewTextBoxColumn.HeaderText = "CDirts";
            this.cDirtsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cDirtsDataGridViewTextBoxColumn.Name = "cDirtsDataGridViewTextBoxColumn";
            this.cDirtsDataGridViewTextBoxColumn.Width = 150;
            // 
            // nRootsDataGridViewTextBoxColumn
            // 
            this.nRootsDataGridViewTextBoxColumn.DataPropertyName = "NRoots";
            this.nRootsDataGridViewTextBoxColumn.HeaderText = "NRoots";
            this.nRootsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nRootsDataGridViewTextBoxColumn.Name = "nRootsDataGridViewTextBoxColumn";
            this.nRootsDataGridViewTextBoxColumn.Width = 150;
            // 
            // cRootsDataGridViewTextBoxColumn
            // 
            this.cRootsDataGridViewTextBoxColumn.DataPropertyName = "CRoots";
            this.cRootsDataGridViewTextBoxColumn.HeaderText = "CRoots";
            this.cRootsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cRootsDataGridViewTextBoxColumn.Name = "cRootsDataGridViewTextBoxColumn";
            this.cRootsDataGridViewTextBoxColumn.Width = 150;
            // 
            // nRocksDataGridViewTextBoxColumn
            // 
            this.nRocksDataGridViewTextBoxColumn.DataPropertyName = "NRocks";
            this.nRocksDataGridViewTextBoxColumn.HeaderText = "NRocks";
            this.nRocksDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nRocksDataGridViewTextBoxColumn.Name = "nRocksDataGridViewTextBoxColumn";
            this.nRocksDataGridViewTextBoxColumn.Width = 150;
            // 
            // cRocksDataGridViewTextBoxColumn
            // 
            this.cRocksDataGridViewTextBoxColumn.DataPropertyName = "CRocks";
            this.cRocksDataGridViewTextBoxColumn.HeaderText = "CRocks";
            this.cRocksDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cRocksDataGridViewTextBoxColumn.Name = "cRocksDataGridViewTextBoxColumn";
            this.cRocksDataGridViewTextBoxColumn.Width = 150;
            // 
            // levelDataGridViewCheckBoxColumn
            // 
            this.levelDataGridViewCheckBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewCheckBoxColumn.HeaderText = "Level";
            this.levelDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.levelDataGridViewCheckBoxColumn.Name = "levelDataGridViewCheckBoxColumn";
            this.levelDataGridViewCheckBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2440, 1677);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.RockInput);
            this.Controls.Add(this.RootsInput);
            this.Controls.Add(this.DirtInput);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PossibleRoots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lakiaro Solver";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.DirtInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Calculate;
        private Customized_Tool.CellButton DirtButton;
        private Customized_Tool.CellButton RockButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PossibleRoots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Customized_Tool.CellButton QuestionButton;
        private Customized_Tool.ToggleButton toggleButton1;
        private Customized_Tool.CellButton cell_button1;
        private System.Windows.Forms.NumericUpDown DirtInput;
        private System.Windows.Forms.NumericUpDown RootsInput;
        private System.Windows.Forms.NumericUpDown RockInput;
        private Customized_Tool.CellButton SouthButton;
        private Customized_Tool.CellButton WestButton;
        private Customized_Tool.CellButton EndButton;
        private Customized_Tool.CellButton NorthButton;
        private Customized_Tool.CellButton EastButton;
        private Customized_Tool.CellButton ThickButton;
        private Customized_Tool.CellButton ThinButton;
        private Customized_Tool.CellButton NarrowButton;
        private Customized_Tool.CellButton cellButton1;
        private GridControl gridControl1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource solverBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDirtsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDirtsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRootsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRootsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRocksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRocksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn levelDataGridViewCheckBoxColumn;
    }
}

