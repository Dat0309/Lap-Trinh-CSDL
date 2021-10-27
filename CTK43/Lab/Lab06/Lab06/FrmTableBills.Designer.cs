
namespace Lab06
{
    partial class FrmTableBills
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
            this.lbxDate = new System.Windows.Forms.ListBox();
            this.dgvTableBills = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableBills)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxDate
            // 
            this.lbxDate.FormattingEnabled = true;
            this.lbxDate.ItemHeight = 16;
            this.lbxDate.Location = new System.Drawing.Point(12, 12);
            this.lbxDate.Name = "lbxDate";
            this.lbxDate.Size = new System.Drawing.Size(249, 532);
            this.lbxDate.TabIndex = 0;
            this.lbxDate.SelectedIndexChanged += new System.EventHandler(this.lbxDate_SelectedIndexChanged);
            // 
            // dgvTableBills
            // 
            this.dgvTableBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableBills.Location = new System.Drawing.Point(267, 12);
            this.dgvTableBills.Name = "dgvTableBills";
            this.dgvTableBills.RowHeadersWidth = 51;
            this.dgvTableBills.RowTemplate.Height = 24;
            this.dgvTableBills.Size = new System.Drawing.Size(709, 537);
            this.dgvTableBills.TabIndex = 1;
            // 
            // FrmTableBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 550);
            this.Controls.Add(this.dgvTableBills);
            this.Controls.Add(this.lbxDate);
            this.Name = "FrmTableBills";
            this.Text = "FrmTableBills";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDate;
        private System.Windows.Forms.DataGridView dgvTableBills;
    }
}