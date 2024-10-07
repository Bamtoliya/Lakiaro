namespace LakiaroCalculator.Customized_Tool
{
    partial class RootTypeControl
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
            LakiaroCalculator.Src.Cell cell1 = new LakiaroCalculator.Src.Cell();
            LakiaroCalculator.Src.Cell cell2 = new LakiaroCalculator.Src.Cell();
            LakiaroCalculator.Src.Cell cell3 = new LakiaroCalculator.Src.Cell();
            LakiaroCalculator.Src.Cell cell4 = new LakiaroCalculator.Src.Cell();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rootButton4 = new LakiaroCalculator.Customized_Tool.RootButton();
            this.rootButton3 = new LakiaroCalculator.Customized_Tool.RootButton();
            this.rootButton1 = new LakiaroCalculator.Customized_Tool.RootButton();
            this.rootButton2 = new LakiaroCalculator.Customized_Tool.RootButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.rootButton4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rootButton3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rootButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rootButton2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(256, 64);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(256, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rootButton4
            // 
            cell1.RootType = LakiaroCalculator.Src.RootType.End;
            cell1.TileType = LakiaroCalculator.Src.TileType.Root;
            this.rootButton4.Cell = cell1;
            this.rootButton4.Image = global::LakiaroCalculator.Properties.Resources._4W;
            this.rootButton4.Location = new System.Drawing.Point(192, 0);
            this.rootButton4.Margin = new System.Windows.Forms.Padding(0);
            this.rootButton4.Name = "rootButton4";
            this.rootButton4.Size = new System.Drawing.Size(64, 64);
            this.rootButton4.TabIndex = 3;
            this.rootButton4.Text = "End";
            this.rootButton4.UseVisualStyleBackColor = true;
            this.rootButton4.Click += new System.EventHandler(this.Button_Click);
            // 
            // rootButton3
            // 
            cell2.RootType = LakiaroCalculator.Src.RootType.Thin;
            cell2.TileType = LakiaroCalculator.Src.TileType.Root;
            this.rootButton3.Cell = cell2;
            this.rootButton3.Image = global::LakiaroCalculator.Properties.Resources._3SE;
            this.rootButton3.Location = new System.Drawing.Point(128, 0);
            this.rootButton3.Margin = new System.Windows.Forms.Padding(0);
            this.rootButton3.Name = "rootButton3";
            this.rootButton3.Size = new System.Drawing.Size(64, 64);
            this.rootButton3.TabIndex = 2;
            this.rootButton3.Text = "Thin";
            this.rootButton3.UseVisualStyleBackColor = true;
            this.rootButton3.Click += new System.EventHandler(this.Button_Click);
            // 
            // rootButton1
            // 
            cell3.RootType = LakiaroCalculator.Src.RootType.Thin;
            cell3.TileType = LakiaroCalculator.Src.TileType.Root;
            this.rootButton1.Cell = cell3;
            this.rootButton1.Image = global::LakiaroCalculator.Properties.Resources._1WE;
            this.rootButton1.Location = new System.Drawing.Point(0, 0);
            this.rootButton1.Margin = new System.Windows.Forms.Padding(0);
            this.rootButton1.Name = "rootButton1";
            this.rootButton1.Size = new System.Drawing.Size(64, 64);
            this.rootButton1.TabIndex = 0;
            this.rootButton1.Text = "Thick";
            this.rootButton1.UseVisualStyleBackColor = true;
            this.rootButton1.Click += new System.EventHandler(this.Button_Click);
            // 
            // rootButton2
            // 
            cell4.RootType = LakiaroCalculator.Src.RootType.Narrow;
            cell4.TileType = LakiaroCalculator.Src.TileType.Root;
            this.rootButton2.Cell = cell4;
            this.rootButton2.Image = global::LakiaroCalculator.Properties.Resources._2WE;
            this.rootButton2.Location = new System.Drawing.Point(64, 0);
            this.rootButton2.Margin = new System.Windows.Forms.Padding(0);
            this.rootButton2.Name = "rootButton2";
            this.rootButton2.Size = new System.Drawing.Size(64, 64);
            this.rootButton2.TabIndex = 1;
            this.rootButton2.Text = "Narrow";
            this.rootButton2.UseVisualStyleBackColor = true;
            this.rootButton2.Click += new System.EventHandler(this.Button_Click);
            // 
            // RootTypeControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(256, 64);
            this.MinimumSize = new System.Drawing.Size(256, 64);
            this.Name = "RootTypeControl";
            this.Size = new System.Drawing.Size(256, 64);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
        private LakiaroCalculator.Customized_Tool.RootButton rootButton1;
        private LakiaroCalculator.Customized_Tool.RootButton rootButton2;
        private LakiaroCalculator.Customized_Tool.RootButton rootButton3;
        private RootButton rootButton4;
    }
}
