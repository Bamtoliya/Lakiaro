using LakiaroCalculator.Src;

namespace LakiaroCalculator.Customized_Tool
{
    partial class TileTypeControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton1 = new LakiaroCalculator.Customized_Tool.TileButton();
            this.tileButton2 = new LakiaroCalculator.Customized_Tool.TileButton();
            this.tileButton3 = new LakiaroCalculator.Customized_Tool.TileButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Controls.Add(this.tileButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileButton3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(274, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tileButton1
            // 
            cell1.RootType = LakiaroCalculator.Src.RootType.None;
            cell1.TileType = LakiaroCalculator.Src.TileType.Dirt;
            this.tileButton1.Cell = cell1;
            this.tileButton1.Image = global::LakiaroCalculator.Properties.Resources.Dirt;
            this.tileButton1.Location = new System.Drawing.Point(3, 3);
            this.tileButton1.Name = "tileButton1";
            this.tileButton1.Size = new System.Drawing.Size(83, 87);
            this.tileButton1.TabIndex = 3;
            this.tileButton1.Text = "tileButton1";
            this.tileButton1.UseVisualStyleBackColor = true;
            this.tileButton1.Click += new System.EventHandler(this.Button_Click);
            // 
            // tileButton2
            // 
            cell2.RootType = LakiaroCalculator.Src.RootType.None;
            cell2.TileType = LakiaroCalculator.Src.TileType.Rock;
            this.tileButton2.Cell = cell2;
            this.tileButton2.Image = global::LakiaroCalculator.Properties.Resources.Rock;
            this.tileButton2.Location = new System.Drawing.Point(95, 4);
            this.tileButton2.Margin = new System.Windows.Forms.Padding(4);
            this.tileButton2.Name = "tileButton2";
            this.tileButton2.Size = new System.Drawing.Size(83, 87);
            this.tileButton2.TabIndex = 1;
            this.tileButton2.Text = "button2";
            this.tileButton2.UseVisualStyleBackColor = true;
            this.tileButton2.Click += new System.EventHandler(this.Button_Click);
            // 
            // tileButton3
            // 
            this.tileButton3.BackColor = System.Drawing.SystemColors.ControlText;
            cell3.RootType = LakiaroCalculator.Src.RootType.None;
            cell3.TileType = LakiaroCalculator.Src.TileType.Question;
            this.tileButton3.Cell = cell3;
            this.tileButton3.Image = global::LakiaroCalculator.Properties.Resources.Question;
            this.tileButton3.Location = new System.Drawing.Point(186, 4);
            this.tileButton3.Margin = new System.Windows.Forms.Padding(4);
            this.tileButton3.Name = "tileButton3";
            this.tileButton3.Size = new System.Drawing.Size(83, 87);
            this.tileButton3.TabIndex = 2;
            this.tileButton3.Text = "tileButton3";
            this.tileButton3.UseVisualStyleBackColor = false;
            this.tileButton3.Click += new System.EventHandler(this.Button_Click);
            // 
            // TileTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TileTypeControl";
            this.Size = new System.Drawing.Size(274, 96);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TileButton tileButton1;
        private TileButton tileButton2;
        private TileButton tileButton3;
    }
}
