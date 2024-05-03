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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reset = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.TilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RootsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DirectionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DirtInput = new System.Windows.Forms.NumericUpDown();
            this.RootsInput = new System.Windows.Forms.NumericUpDown();
            this.RockInput = new System.Windows.Forms.NumericUpDown();
            this.PossibleRoots = new System.Windows.Forms.Label();
            this.ThickButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.NarrowButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.ThinButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.DirtButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.RockButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.QuestionButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.cell_button1 = new LakiaroCalculator.Customized_Tool.CellButton();
            this.WestButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.EndButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.NorthButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.EastButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.SouthButton = new LakiaroCalculator.Customized_Tool.CellButton();
            this.toggleButton1 = new LakiaroCalculator.Customized_Tool.ToggleButton();
            this.TilesPanel.SuspendLayout();
            this.GridPanel.SuspendLayout();
            this.RootsPanel.SuspendLayout();
            this.DirectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirtInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(156, 179);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(65, 55);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.UseWaitCursor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(81, 179);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(69, 55);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.UseWaitCursor = true;
            // 
            // TilesPanel
            // 
            this.TilesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TilesPanel.AutoScroll = true;
            this.TilesPanel.Controls.Add(this.DirtButton);
            this.TilesPanel.Controls.Add(this.RockButton);
            this.TilesPanel.Controls.Add(this.QuestionButton);
            this.TilesPanel.Location = new System.Drawing.Point(78, 685);
            this.TilesPanel.Name = "TilesPanel";
            this.TilesPanel.Size = new System.Drawing.Size(198, 66);
            this.TilesPanel.TabIndex = 13;
            this.TilesPanel.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(74, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dirt";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(74, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rock";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(74, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Root";
            this.label3.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("굴림", 20F);
            this.label5.Location = new System.Drawing.Point(80, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Recommendation";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("굴림", 20F);
            this.label6.Location = new System.Drawing.Point(80, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "Flower";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("굴림", 20F);
            this.label7.Location = new System.Drawing.Point(80, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Possible Root";
            this.label7.UseWaitCursor = true;
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.GridPanel.ColumnCount = 16;
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.Controls.Add(this.cell_button1, 0, 0);
            this.GridPanel.Location = new System.Drawing.Point(397, 51);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.RowCount = 16;
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.GridPanel.Size = new System.Drawing.Size(1024, 1024);
            this.GridPanel.TabIndex = 28;
            this.GridPanel.UseWaitCursor = true;
            // 
            // RootsPanel
            // 
            this.RootsPanel.Controls.Add(this.ThickButton);
            this.RootsPanel.Controls.Add(this.NarrowButton);
            this.RootsPanel.Controls.Add(this.ThinButton);
            this.RootsPanel.Location = new System.Drawing.Point(79, 754);
            this.RootsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RootsPanel.Name = "RootsPanel";
            this.RootsPanel.Size = new System.Drawing.Size(198, 66);
            this.RootsPanel.TabIndex = 31;
            this.RootsPanel.UseWaitCursor = true;
            // 
            // DirectionPanel
            // 
            this.DirectionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirectionPanel.BackColor = System.Drawing.Color.Transparent;
            this.DirectionPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DirectionPanel.ColumnCount = 3;
            this.DirectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.DirectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.DirectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.DirectionPanel.Controls.Add(this.WestButton, 0, 1);
            this.DirectionPanel.Controls.Add(this.EndButton, 1, 1);
            this.DirectionPanel.Controls.Add(this.NorthButton, 1, 0);
            this.DirectionPanel.Controls.Add(this.EastButton, 2, 1);
            this.DirectionPanel.Controls.Add(this.SouthButton, 1, 2);
            this.DirectionPanel.Location = new System.Drawing.Point(72, 369);
            this.DirectionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DirectionPanel.Name = "DirectionPanel";
            this.DirectionPanel.RowCount = 3;
            this.DirectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.DirectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.DirectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.DirectionPanel.Size = new System.Drawing.Size(192, 192);
            this.DirectionPanel.TabIndex = 27;
            this.DirectionPanel.UseWaitCursor = true;
            // 
            // DirtInput
            // 
            this.DirtInput.Location = new System.Drawing.Point(152, 47);
            this.DirtInput.Name = "DirtInput";
            this.DirtInput.Size = new System.Drawing.Size(120, 21);
            this.DirtInput.TabIndex = 29;
            this.DirtInput.UseWaitCursor = true;
            // 
            // RootsInput
            // 
            this.RootsInput.Location = new System.Drawing.Point(152, 75);
            this.RootsInput.Name = "RootsInput";
            this.RootsInput.Size = new System.Drawing.Size(120, 21);
            this.RootsInput.TabIndex = 30;
            this.RootsInput.UseWaitCursor = true;
            this.RootsInput.ValueChanged += new System.EventHandler(this.CacluateRoots);
            // 
            // RockInput
            // 
            this.RockInput.Location = new System.Drawing.Point(152, 104);
            this.RockInput.Name = "RockInput";
            this.RockInput.Size = new System.Drawing.Size(120, 21);
            this.RockInput.TabIndex = 30;
            this.RockInput.UseWaitCursor = true;
            // 
            // PossibleRoots
            // 
            this.PossibleRoots.AutoSize = true;
            this.PossibleRoots.Font = new System.Drawing.Font("굴림", 20F);
            this.PossibleRoots.Location = new System.Drawing.Point(76, 140);
            this.PossibleRoots.Name = "PossibleRoots";
            this.PossibleRoots.Size = new System.Drawing.Size(232, 27);
            this.PossibleRoots.TabIndex = 20;
            this.PossibleRoots.Text = "Possible Roots: 0";
            this.PossibleRoots.UseWaitCursor = true;
            // 
            // ThickButton
            // 
            this.ThickButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ThickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThickButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ThickButton.Image = global::LakiaroCalculator.Properties.Resources._1;
            this.ThickButton.Location = new System.Drawing.Point(1, 1);
            this.ThickButton.Margin = new System.Windows.Forms.Padding(1);
            this.ThickButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.ThickButton.Name = "ThickButton";
            this.ThickButton.RootType = ((short)(1));
            this.ThickButton.Size = new System.Drawing.Size(64, 64);
            this.ThickButton.TabIndex = 13;
            this.ThickButton.Text = "Thick";
            this.ThickButton.TileType = ((short)(0));
            this.ThickButton.Type = ((short)(128));
            this.ThickButton.UseVisualStyleBackColor = false;
            this.ThickButton.UseWaitCursor = true;
            this.ThickButton.Click += new System.EventHandler(this.RootButtonClicked);
            // 
            // NarrowButton
            // 
            this.NarrowButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.NarrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NarrowButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NarrowButton.Image = global::LakiaroCalculator.Properties.Resources._1W_4E1;
            this.NarrowButton.Location = new System.Drawing.Point(67, 1);
            this.NarrowButton.Margin = new System.Windows.Forms.Padding(1);
            this.NarrowButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.NarrowButton.Name = "NarrowButton";
            this.NarrowButton.RootType = ((short)(0));
            this.NarrowButton.Size = new System.Drawing.Size(64, 64);
            this.NarrowButton.TabIndex = 15;
            this.NarrowButton.Text = "Narrow";
            this.NarrowButton.TileType = ((short)(0));
            this.NarrowButton.Type = ((short)(64));
            this.NarrowButton.UseVisualStyleBackColor = false;
            this.NarrowButton.UseWaitCursor = true;
            this.NarrowButton.Click += new System.EventHandler(this.RootButtonClicked);
            // 
            // ThinButton
            // 
            this.ThinButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ThinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThinButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ThinButton.Image = global::LakiaroCalculator.Properties.Resources._11;
            this.ThinButton.Location = new System.Drawing.Point(133, 1);
            this.ThinButton.Margin = new System.Windows.Forms.Padding(1);
            this.ThinButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.ThinButton.Name = "ThinButton";
            this.ThinButton.RootType = ((short)(0));
            this.ThinButton.Size = new System.Drawing.Size(64, 64);
            this.ThinButton.TabIndex = 14;
            this.ThinButton.Text = "Thin";
            this.ThinButton.TileType = ((short)(0));
            this.ThinButton.Type = ((short)(32));
            this.ThinButton.UseVisualStyleBackColor = false;
            this.ThinButton.UseWaitCursor = true;
            this.ThinButton.Click += new System.EventHandler(this.RootButtonClicked);
            // 
            // DirtButton
            // 
            this.DirtButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.DirtButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DirtButton.Image = global::LakiaroCalculator.Properties.Resources._0;
            this.DirtButton.Location = new System.Drawing.Point(1, 1);
            this.DirtButton.Margin = new System.Windows.Forms.Padding(1);
            this.DirtButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.DirtButton.Name = "DirtButton";
            this.DirtButton.RootType = ((short)(0));
            this.DirtButton.Size = new System.Drawing.Size(64, 64);
            this.DirtButton.TabIndex = 11;
            this.DirtButton.Text = "Dirt";
            this.DirtButton.TileType = ((short)(0));
            this.DirtButton.Type = ((short)(0));
            this.DirtButton.UseVisualStyleBackColor = false;
            this.DirtButton.UseWaitCursor = true;
            this.DirtButton.Click += new System.EventHandler(this.TileButtonClicked);
            // 
            // RockButton
            // 
            this.RockButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.RockButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RockButton.Image = global::LakiaroCalculator.Properties.Resources._00;
            this.RockButton.Location = new System.Drawing.Point(67, 1);
            this.RockButton.Margin = new System.Windows.Forms.Padding(1);
            this.RockButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.RockButton.Name = "RockButton";
            this.RockButton.RootType = ((short)(0));
            this.RockButton.Size = new System.Drawing.Size(64, 64);
            this.RockButton.TabIndex = 12;
            this.RockButton.Text = "Rock";
            this.RockButton.TileType = ((short)(0));
            this.RockButton.Type = ((short)(0));
            this.RockButton.UseVisualStyleBackColor = false;
            this.RockButton.UseWaitCursor = true;
            this.RockButton.Click += new System.EventHandler(this.TileButtonClicked);
            // 
            // QuestionButton
            // 
            this.QuestionButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.QuestionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.QuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("QuestionButton.Image")));
            this.QuestionButton.Location = new System.Drawing.Point(133, 1);
            this.QuestionButton.Margin = new System.Windows.Forms.Padding(1);
            this.QuestionButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.RootType = ((short)(0));
            this.QuestionButton.Size = new System.Drawing.Size(64, 64);
            this.QuestionButton.TabIndex = 20;
            this.QuestionButton.Text = "button154";
            this.QuestionButton.TileType = ((short)(0));
            this.QuestionButton.Type = ((short)(0));
            this.QuestionButton.UseVisualStyleBackColor = false;
            this.QuestionButton.UseWaitCursor = true;
            this.QuestionButton.Click += new System.EventHandler(this.TileButtonClicked);
            // 
            // cell_button1
            // 
            this.cell_button1.BackColor = System.Drawing.Color.SkyBlue;
            this.cell_button1.Location = new System.Drawing.Point(0, 0);
            this.cell_button1.Margin = new System.Windows.Forms.Padding(0);
            this.cell_button1.MinimumSize = new System.Drawing.Size(64, 64);
            this.cell_button1.Name = "cell_button1";
            this.cell_button1.RootType = ((short)(0));
            this.cell_button1.Size = new System.Drawing.Size(64, 64);
            this.cell_button1.TabIndex = 29;
            this.cell_button1.TileType = ((short)(0));
            this.cell_button1.Type = ((short)(0));
            this.cell_button1.UseVisualStyleBackColor = false;
            this.cell_button1.UseWaitCursor = true;
            this.cell_button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cell_Button_Clicked);
            // 
            // WestButton
            // 
            this.WestButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.WestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WestButton.Image = global::LakiaroCalculator.Properties.Resources.WestArrow;
            this.WestButton.Location = new System.Drawing.Point(1, 66);
            this.WestButton.Margin = new System.Windows.Forms.Padding(0);
            this.WestButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.WestButton.Name = "WestButton";
            this.WestButton.RootType = ((short)(0));
            this.WestButton.Size = new System.Drawing.Size(64, 64);
            this.WestButton.TabIndex = 34;
            this.WestButton.Text = "West";
            this.WestButton.TileType = ((short)(0));
            this.WestButton.Type = ((short)(87));
            this.WestButton.UseVisualStyleBackColor = false;
            this.WestButton.UseWaitCursor = true;
            this.WestButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DirectionButtonCliked);
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.EndButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EndButton.Location = new System.Drawing.Point(66, 66);
            this.EndButton.Margin = new System.Windows.Forms.Padding(0);
            this.EndButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.EndButton.Name = "EndButton";
            this.EndButton.RootType = ((short)(0));
            this.EndButton.Size = new System.Drawing.Size(64, 64);
            this.EndButton.TabIndex = 36;
            this.EndButton.Text = "End";
            this.EndButton.TileType = ((short)(0));
            this.EndButton.Type = ((short)(67));
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.UseWaitCursor = true;
            this.EndButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DirectionButtonCliked);
            // 
            // NorthButton
            // 
            this.NorthButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.NorthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NorthButton.Image = global::LakiaroCalculator.Properties.Resources.NorthArrow;
            this.NorthButton.Location = new System.Drawing.Point(66, 1);
            this.NorthButton.Margin = new System.Windows.Forms.Padding(0);
            this.NorthButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.NorthButton.Name = "NorthButton";
            this.NorthButton.RootType = ((short)(0));
            this.NorthButton.Size = new System.Drawing.Size(64, 64);
            this.NorthButton.TabIndex = 35;
            this.NorthButton.Text = "North";
            this.NorthButton.TileType = ((short)(0));
            this.NorthButton.Type = ((short)(78));
            this.NorthButton.UseVisualStyleBackColor = false;
            this.NorthButton.UseWaitCursor = true;
            this.NorthButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DirectionButtonCliked);
            // 
            // EastButton
            // 
            this.EastButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.EastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EastButton.Image = global::LakiaroCalculator.Properties.Resources.EastArrow;
            this.EastButton.Location = new System.Drawing.Point(131, 66);
            this.EastButton.Margin = new System.Windows.Forms.Padding(0);
            this.EastButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.EastButton.Name = "EastButton";
            this.EastButton.RootType = ((short)(0));
            this.EastButton.Size = new System.Drawing.Size(64, 64);
            this.EastButton.TabIndex = 33;
            this.EastButton.Text = "East";
            this.EastButton.TileType = ((short)(0));
            this.EastButton.Type = ((short)(69));
            this.EastButton.UseVisualStyleBackColor = false;
            this.EastButton.UseWaitCursor = true;
            this.EastButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DirectionButtonCliked);
            // 
            // SouthButton
            // 
            this.SouthButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SouthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SouthButton.Image = global::LakiaroCalculator.Properties.Resources.SouthArrow;
            this.SouthButton.Location = new System.Drawing.Point(66, 131);
            this.SouthButton.Margin = new System.Windows.Forms.Padding(0);
            this.SouthButton.MinimumSize = new System.Drawing.Size(64, 64);
            this.SouthButton.Name = "SouthButton";
            this.SouthButton.RootType = ((short)(0));
            this.SouthButton.Size = new System.Drawing.Size(64, 64);
            this.SouthButton.TabIndex = 32;
            this.SouthButton.Text = "South";
            this.SouthButton.TileType = ((short)(0));
            this.SouthButton.Type = ((short)(83));
            this.SouthButton.UseVisualStyleBackColor = false;
            this.SouthButton.UseWaitCursor = true;
            this.SouthButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DirectionButtonCliked);
            // 
            // toggleButton1
            // 
            this.toggleButton1.Location = new System.Drawing.Point(79, 583);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Beige;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumAquamarine;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(120, 50);
            this.toggleButton1.TabIndex = 25;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.UseVisualStyleBackColor = true;
            this.toggleButton1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1708, 1118);
            this.Controls.Add(this.TilesPanel);
            this.Controls.Add(this.RootsPanel);
            this.Controls.Add(this.DirectionPanel);
            this.Controls.Add(this.RockInput);
            this.Controls.Add(this.RootsInput);
            this.Controls.Add(this.DirtInput);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PossibleRoots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lakiaro Solver";
            this.UseWaitCursor = true;
            this.TilesPanel.ResumeLayout(false);
            this.GridPanel.ResumeLayout(false);
            this.RootsPanel.ResumeLayout(false);
            this.DirectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DirtInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockInput)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel TilesPanel;
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
        private System.Windows.Forms.TableLayoutPanel DirectionPanel;
        private System.Windows.Forms.TableLayoutPanel GridPanel;
        private Customized_Tool.CellButton cell_button1;
        private System.Windows.Forms.NumericUpDown DirtInput;
        private System.Windows.Forms.NumericUpDown RootsInput;
        private System.Windows.Forms.NumericUpDown RockInput;
        private System.Windows.Forms.FlowLayoutPanel RootsPanel;
        private Customized_Tool.CellButton SouthButton;
        private Customized_Tool.CellButton WestButton;
        private Customized_Tool.CellButton EndButton;
        private Customized_Tool.CellButton NorthButton;
        private Customized_Tool.CellButton EastButton;
        private Customized_Tool.CellButton ThickButton;
        private Customized_Tool.CellButton ThinButton;
        private Customized_Tool.CellButton NarrowButton;
    }
}

