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
            this.Reset = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.TilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RootsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DirtInput = new System.Windows.Forms.NumericUpDown();
            this.RootsInput = new System.Windows.Forms.NumericUpDown();
            this.RockInput = new System.Windows.Forms.NumericUpDown();
            this.PossibleRoots = new System.Windows.Forms.Label();
            this.gridControl1 = new LakiaroCalculator.Customized_Tool.GridControl();
            this.toggleButton1 = new LakiaroCalculator.Customized_Tool.ToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DirtInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(223, 268);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Calculate.Location = new System.Drawing.Point(116, 268);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(99, 82);
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
            this.TilesPanel.Location = new System.Drawing.Point(111, 1028);
            this.TilesPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TilesPanel.Name = "TilesPanel";
            this.TilesPanel.Size = new System.Drawing.Size(283, 99);
            this.TilesPanel.TabIndex = 13;
            this.TilesPanel.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(106, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dirt";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(106, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rock";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(106, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 40);
            this.label3.TabIndex = 19;
            this.label3.Text = "Root";
            this.label3.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("굴림", 20F);
            this.label5.Location = new System.Drawing.Point(114, 394);
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
            this.label6.Location = new System.Drawing.Point(114, 474);
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
            this.label7.Location = new System.Drawing.Point(113, 434);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 40);
            this.label7.TabIndex = 24;
            this.label7.Text = "Possible Root";
            this.label7.UseWaitCursor = true;
            // 
            // RootsPanel
            // 
            this.RootsPanel.Location = new System.Drawing.Point(113, 1131);
            this.RootsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RootsPanel.Name = "RootsPanel";
            this.RootsPanel.Size = new System.Drawing.Size(283, 99);
            this.RootsPanel.TabIndex = 31;
            this.RootsPanel.UseWaitCursor = true;
            // 
            // DirtInput
            // 
            this.DirtInput.Location = new System.Drawing.Point(217, 70);
            this.DirtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DirtInput.Name = "DirtInput";
            this.DirtInput.Size = new System.Drawing.Size(171, 28);
            this.DirtInput.TabIndex = 29;
            this.DirtInput.UseWaitCursor = true;
            // 
            // RootsInput
            // 
            this.RootsInput.Location = new System.Drawing.Point(217, 112);
            this.RootsInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RootsInput.Name = "RootsInput";
            this.RootsInput.Size = new System.Drawing.Size(171, 28);
            this.RootsInput.TabIndex = 30;
            this.RootsInput.UseWaitCursor = true;
            this.RootsInput.ValueChanged += new System.EventHandler(this.CacluateRoots);
            // 
            // RockInput
            // 
            this.RockInput.Location = new System.Drawing.Point(217, 156);
            this.RockInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RockInput.Name = "RockInput";
            this.RockInput.Size = new System.Drawing.Size(171, 28);
            this.RockInput.TabIndex = 30;
            this.RockInput.UseWaitCursor = true;
            // 
            // PossibleRoots
            // 
            this.PossibleRoots.AutoSize = true;
            this.PossibleRoots.Font = new System.Drawing.Font("굴림", 20F);
            this.PossibleRoots.Location = new System.Drawing.Point(109, 210);
            this.PossibleRoots.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PossibleRoots.Name = "PossibleRoots";
            this.PossibleRoots.Size = new System.Drawing.Size(345, 40);
            this.PossibleRoots.TabIndex = 20;
            this.PossibleRoots.Text = "Possible Roots: 0";
            this.PossibleRoots.UseWaitCursor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridControl1.Location = new System.Drawing.Point(646, 70);
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.MinimumSize = new System.Drawing.Size(1097, 1152);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1097, 1152);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.UseWaitCursor = true;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Location = new System.Drawing.Point(113, 874);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2440, 1677);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.TilesPanel);
            this.Controls.Add(this.RootsPanel);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lakiaro Solver";
            this.UseWaitCursor = true;
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
        private Customized_Tool.CellButton cellButton1;
        private GridControl gridControl1;
    }
}

