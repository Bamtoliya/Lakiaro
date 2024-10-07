namespace LakiaroCalculator.Customized_Tool
{
    partial class DirectionControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.northButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.northButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.eastButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.westButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.southButton, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(192, 192);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(192, 192);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // northButton
            // 
            this.northButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.northButton.BackgroundImage = global::LakiaroCalculator.Properties.Resources.NorthArrow;
            this.northButton.Location = new System.Drawing.Point(64, 0);
            this.northButton.Margin = new System.Windows.Forms.Padding(0);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(64, 64);
            this.northButton.TabIndex = 0;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = false;
            this.northButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // eastButton
            // 
            this.eastButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.eastButton.BackgroundImage = global::LakiaroCalculator.Properties.Resources.EastArrow;
            this.eastButton.Location = new System.Drawing.Point(128, 64);
            this.eastButton.Margin = new System.Windows.Forms.Padding(0);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(64, 64);
            this.eastButton.TabIndex = 0;
            this.eastButton.Text = "East";
            this.eastButton.UseVisualStyleBackColor = false;
            this.eastButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // westButton
            // 
            this.westButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.westButton.BackgroundImage = global::LakiaroCalculator.Properties.Resources.WestArrow;
            this.westButton.Location = new System.Drawing.Point(0, 64);
            this.westButton.Margin = new System.Windows.Forms.Padding(0);
            this.westButton.Name = "westButton";
            this.westButton.Size = new System.Drawing.Size(64, 64);
            this.westButton.TabIndex = 0;
            this.westButton.Text = "West";
            this.westButton.UseVisualStyleBackColor = false;
            this.westButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // southButton
            // 
            this.southButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.southButton.BackgroundImage = global::LakiaroCalculator.Properties.Resources.SouthArrow;
            this.southButton.Location = new System.Drawing.Point(64, 128);
            this.southButton.Margin = new System.Windows.Forms.Padding(0);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(64, 64);
            this.southButton.TabIndex = 0;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = false;
            this.southButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // DirectionControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(192, 192);
            this.MinimumSize = new System.Drawing.Size(192, 192);
            this.Name = "DirectionControl";
            this.Size = new System.Drawing.Size(192, 192);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button southButton;
    }
}
