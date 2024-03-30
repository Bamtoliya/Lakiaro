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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button154 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toggleButton1 = new LakiaroCalculator.ToggleButton.ToggleButton();
            this.button155 = new System.Windows.Forms.Button();
            this.button156 = new System.Windows.Forms.Button();
            this.button157 = new System.Windows.Forms.Button();
            this.button158 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cell_button1 = new LakiaroCalculator.CellButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.TilesPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
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
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
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
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // TilesPanel
            // 
            this.TilesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TilesPanel.AutoScroll = true;
            this.TilesPanel.Controls.Add(this.button1);
            this.TilesPanel.Controls.Add(this.button2);
            this.TilesPanel.Controls.Add(this.button154);
            this.TilesPanel.Controls.Add(this.button5);
            this.TilesPanel.Controls.Add(this.button3);
            this.TilesPanel.Controls.Add(this.button4);
            this.TilesPanel.Location = new System.Drawing.Point(447, 47);
            this.TilesPanel.Name = "TilesPanel";
            this.TilesPanel.Size = new System.Drawing.Size(230, 71);
            this.TilesPanel.TabIndex = 13;
            this.TilesPanel.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::LakiaroCalculator.Properties.Resources._0;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dirt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.TileButtonClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::LakiaroCalculator.Properties.Resources._00;
            this.button2.Location = new System.Drawing.Point(73, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 12;
            this.button2.Text = "Rock";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            // 
            // button154
            // 
            this.button154.BackColor = System.Drawing.SystemColors.Desktop;
            this.button154.ForeColor = System.Drawing.SystemColors.Control;
            this.button154.Image = ((System.Drawing.Image)(resources.GetObject("button154.Image")));
            this.button154.Location = new System.Drawing.Point(143, 3);
            this.button154.Name = "button154";
            this.button154.Size = new System.Drawing.Size(64, 64);
            this.button154.TabIndex = 20;
            this.button154.Text = "button154";
            this.button154.UseVisualStyleBackColor = false;
            this.button154.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Desktop;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Image = global::LakiaroCalculator.Properties.Resources._6;
            this.button5.Location = new System.Drawing.Point(3, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 64);
            this.button5.TabIndex = 15;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::LakiaroCalculator.Properties.Resources._1;
            this.button3.Location = new System.Drawing.Point(73, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Desktop;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::LakiaroCalculator.Properties.Resources._11;
            this.button4.Location = new System.Drawing.Point(143, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F);
            this.label4.Location = new System.Drawing.Point(76, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Possible Roots: 0";
            this.label4.UseWaitCursor = true;
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
            // toggleButton1
            // 
            this.toggleButton1.Location = new System.Drawing.Point(380, -2);
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
            // button155
            // 
            this.button155.BackColor = System.Drawing.SystemColors.Desktop;
            this.button155.Image = global::LakiaroCalculator.Properties.Resources.Arrow;
            this.button155.Location = new System.Drawing.Point(75, 4);
            this.button155.Name = "button155";
            this.button155.Size = new System.Drawing.Size(64, 61);
            this.button155.TabIndex = 0;
            this.button155.Text = "button155";
            this.button155.UseVisualStyleBackColor = false;
            this.button155.UseWaitCursor = true;
            // 
            // button156
            // 
            this.button156.BackColor = System.Drawing.SystemColors.Desktop;
            this.button156.Image = global::LakiaroCalculator.Properties.Resources.Arrow1;
            this.button156.Location = new System.Drawing.Point(146, 72);
            this.button156.Name = "button156";
            this.button156.Size = new System.Drawing.Size(64, 61);
            this.button156.TabIndex = 1;
            this.button156.Text = "button156";
            this.button156.UseVisualStyleBackColor = false;
            this.button156.UseWaitCursor = true;
            // 
            // button157
            // 
            this.button157.BackColor = System.Drawing.SystemColors.Desktop;
            this.button157.Image = global::LakiaroCalculator.Properties.Resources.Arrow2;
            this.button157.Location = new System.Drawing.Point(75, 140);
            this.button157.Name = "button157";
            this.button157.Size = new System.Drawing.Size(64, 64);
            this.button157.TabIndex = 2;
            this.button157.Text = "button157";
            this.button157.UseVisualStyleBackColor = false;
            this.button157.UseWaitCursor = true;
            // 
            // button158
            // 
            this.button158.BackColor = System.Drawing.SystemColors.Desktop;
            this.button158.Image = global::LakiaroCalculator.Properties.Resources.Arrow3;
            this.button158.Location = new System.Drawing.Point(4, 72);
            this.button158.Name = "button158";
            this.button158.Size = new System.Drawing.Size(64, 61);
            this.button158.TabIndex = 3;
            this.button158.Text = "button158";
            this.button158.UseVisualStyleBackColor = false;
            this.button158.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button157, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button155, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button158, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button156, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 367);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 210);
            this.tableLayoutPanel1.TabIndex = 27;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 16;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.Controls.Add(this.cell_button1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(380, 51);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 16;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1024, 1024);
            this.tableLayoutPanel2.TabIndex = 28;
            this.tableLayoutPanel2.UseWaitCursor = true;
            // 
            // cell_button1
            // 
            this.cell_button1.Location = new System.Drawing.Point(0, 0);
            this.cell_button1.Margin = new System.Windows.Forms.Padding(0);
            this.cell_button1.MinimumSize = new System.Drawing.Size(64, 64);
            this.cell_button1.Name = "cell_button1";
            this.cell_button1.Size = new System.Drawing.Size(64, 64);
            this.cell_button1.TabIndex = 29;
            this.cell_button1.Text = "cell_button1";
            this.cell_button1.UseVisualStyleBackColor = true;
            this.cell_button1.UseWaitCursor = true;
            this.cell_button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_Button_Clicked);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.UseWaitCursor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(152, 75);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown2.TabIndex = 30;
            this.numericUpDown2.UseWaitCursor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(152, 104);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown3.TabIndex = 30;
            this.numericUpDown3.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1708, 1118);
            this.Controls.Add(this.TilesPanel);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TilesPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel TilesPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button154;
        private ToggleButton.ToggleButton toggleButton1;
        private System.Windows.Forms.Button button155;
        private System.Windows.Forms.Button button156;
        private System.Windows.Forms.Button button157;
        private System.Windows.Forms.Button button158;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LakiaroCalculator.CellButton cell_button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

