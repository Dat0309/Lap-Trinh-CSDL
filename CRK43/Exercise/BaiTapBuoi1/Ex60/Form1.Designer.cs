
namespace Ex60
{
    partial class DemoCheckListBox
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
            this.clbDanhSach = new System.Windows.Forms.CheckedListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbDanhSach
            // 
            this.clbDanhSach.CheckOnClick = true;
            this.clbDanhSach.FormattingEnabled = true;
            this.clbDanhSach.Location = new System.Drawing.Point(13, 13);
            this.clbDanhSach.MultiColumn = true;
            this.clbDanhSach.Name = "clbDanhSach";
            this.clbDanhSach.Size = new System.Drawing.Size(392, 154);
            this.clbDanhSach.TabIndex = 0;
            this.clbDanhSach.SelectedIndexChanged += new System.EventHandler(this.clbDanhSach_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(169, 174);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // DemoCheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 203);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.clbDanhSach);
            this.Name = "DemoCheckListBox";
            this.Text = "Demo Check List Box";
            this.Load += new System.EventHandler(this.DemoCheckListBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbDanhSach;
        private System.Windows.Forms.Button btnOk;
    }
}

