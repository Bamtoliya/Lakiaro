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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PossibleRoots = new System.Windows.Forms.Label();
            this.toggleButton1 = new LakiaroCalculator.Customized_Tool.ToggleButton();
            this.solverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new LakiaroCalculator.Customized_Tool.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.solverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(855, 708);
            this.Reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(56, 59);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.UseWaitCursor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(791, 708);
            this.Calculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(59, 59);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("굴림", 20F);
            this.label5.Location = new System.Drawing.Point(786, 650);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label6.Location = new System.Drawing.Point(337, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label7.Location = new System.Drawing.Point(786, 623);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Possible Root";
            this.label7.UseWaitCursor = true;
            // 
            // PossibleRoots
            // 
            this.PossibleRoots.AutoSize = true;
            this.PossibleRoots.Font = new System.Drawing.Font("굴림", 20F);
            this.PossibleRoots.Location = new System.Drawing.Point(786, 679);
            this.PossibleRoots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PossibleRoots.Name = "PossibleRoots";
            this.PossibleRoots.Size = new System.Drawing.Size(232, 27);
            this.PossibleRoots.TabIndex = 20;
            this.PossibleRoots.Text = "Possible Roots: 0";
            this.PossibleRoots.UseWaitCursor = true;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Checked = true;
            this.toggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.solverBindingSource, "Level", true));
            this.toggleButton1.Location = new System.Drawing.Point(795, 0);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(38, 24);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Beige;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumAquamarine;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(223, 54);
            this.toggleButton1.TabIndex = 25;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.UseVisualStyleBackColor = true;
            this.toggleButton1.UseWaitCursor = true;
            this.toggleButton1.CheckedChanged += new System.EventHandler(this.toggleButton1_CheckedChanged);
            // 
            // solverBindingSource
            // 
            this.solverBindingSource.DataSource = typeof(LakiaroCalculator.Src.Solver);
            // 
            // gridControl1
            // 
            this.gridControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.MaximumSize = new System.Drawing.Size(896, 896);
            this.gridControl1.MinimumSize = new System.Drawing.Size(768, 768);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(768, 768);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 841);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PossibleRoots);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lakiaro Solver";
            this.UseWaitCursor = true;
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
        private System.Windows.Forms.Label PossibleRoots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Customized_Tool.ToggleButton toggleButton1;
        private GridControl gridControl1;
        private System.Windows.Forms.BindingSource solverBindingSource;
    }
}

