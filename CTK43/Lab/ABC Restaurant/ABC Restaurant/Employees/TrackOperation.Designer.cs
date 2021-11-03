namespace ABC_Restaurant.Employees
{
    partial class TrackOperation
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
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrack
            // 
            this.dgvTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Location = new System.Drawing.Point(2, 2);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.RowHeadersWidth = 51;
            this.dgvTrack.RowTemplate.Height = 29;
            this.dgvTrack.Size = new System.Drawing.Size(796, 446);
            this.dgvTrack.TabIndex = 0;
            // 
            // TrackOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTrack);
            this.Name = "TrackOperation";
            this.Text = "TrackOperation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTrack;
    }
}