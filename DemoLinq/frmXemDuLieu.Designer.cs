namespace DemoLinq
{
    partial class frmXemDuLieu
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnWhere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(926, 666);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 43);
            this.button4.TabIndex = 9;
            this.button4.Text = "GroupBy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(652, 666);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(157, 43);
            this.btnOrderBy.TabIndex = 8;
            this.btnOrderBy.Text = "OrderBy";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(101, 666);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(157, 43);
            this.btnJoin.TabIndex = 6;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 477);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(374, 666);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(157, 43);
            this.btnWhere.TabIndex = 10;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            // 
            // frmXemDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 826);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmXemDuLieu";
            this.Text = "frmXemDuLieu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWhere;
    }
}