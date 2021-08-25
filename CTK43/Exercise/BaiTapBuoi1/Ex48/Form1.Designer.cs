
namespace Ex48
{
    partial class Demo_CBB
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Leaguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the string in the collection (one per line)";
            // 
            // cbb_Leaguage
            // 
            this.cbb_Leaguage.FormattingEnabled = true;
            this.cbb_Leaguage.Location = new System.Drawing.Point(16, 50);
            this.cbb_Leaguage.Name = "cbb_Leaguage";
            this.cbb_Leaguage.Size = new System.Drawing.Size(382, 21);
            this.cbb_Leaguage.TabIndex = 1;
            this.cbb_Leaguage.SelectedIndexChanged += new System.EventHandler(this.cbb_Leaguage_SelectedIndexChanged);
            // 
            // Demo_CBB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 180);
            this.Controls.Add(this.cbb_Leaguage);
            this.Controls.Add(this.label1);
            this.Name = "Demo_CBB";
            this.Text = "Demo Combo Box";
            this.Load += new System.EventHandler(this.Demo_CBB_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Leaguage;
    }
}

