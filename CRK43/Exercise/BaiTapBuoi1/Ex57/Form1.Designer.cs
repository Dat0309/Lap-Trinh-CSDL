
namespace Ex57
{
    partial class Form1
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
            this.cbkMauchu = new System.Windows.Forms.CheckBox();
            this.cbkMauNen = new System.Windows.Forms.CheckBox();
            this.rdFlat = new System.Windows.Forms.RadioButton();
            this.rdPopup = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbkMauchu
            // 
            this.cbkMauchu.AutoSize = true;
            this.cbkMauchu.Location = new System.Drawing.Point(300, 53);
            this.cbkMauchu.Name = "cbkMauchu";
            this.cbkMauchu.Size = new System.Drawing.Size(80, 17);
            this.cbkMauchu.TabIndex = 0;
            this.cbkMauchu.Text = "checkBox1";
            this.cbkMauchu.UseVisualStyleBackColor = true;
            this.cbkMauchu.CheckedChanged += new System.EventHandler(this.cbkMauchu_CheckedChanged);
            // 
            // cbkMauNen
            // 
            this.cbkMauNen.AutoSize = true;
            this.cbkMauNen.Location = new System.Drawing.Point(300, 80);
            this.cbkMauNen.Name = "cbkMauNen";
            this.cbkMauNen.Size = new System.Drawing.Size(80, 17);
            this.cbkMauNen.TabIndex = 1;
            this.cbkMauNen.Text = "checkBox2";
            this.cbkMauNen.UseVisualStyleBackColor = true;
            this.cbkMauNen.CheckedChanged += new System.EventHandler(this.cbkMauNen_CheckedChanged);
            // 
            // rdFlat
            // 
            this.rdFlat.AutoSize = true;
            this.rdFlat.Location = new System.Drawing.Point(300, 156);
            this.rdFlat.Name = "rdFlat";
            this.rdFlat.Size = new System.Drawing.Size(85, 17);
            this.rdFlat.TabIndex = 2;
            this.rdFlat.TabStop = true;
            this.rdFlat.Text = "radioButton1";
            this.rdFlat.UseVisualStyleBackColor = true;
            this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
            // 
            // rdPopup
            // 
            this.rdPopup.AutoSize = true;
            this.rdPopup.Location = new System.Drawing.Point(300, 188);
            this.rdPopup.Name = "rdPopup";
            this.rdPopup.Size = new System.Drawing.Size(85, 17);
            this.rdPopup.TabIndex = 3;
            this.rdPopup.TabStop = true;
            this.rdPopup.Text = "radioButton2";
            this.rdPopup.UseVisualStyleBackColor = true;
            this.rdPopup.CheckedChanged += new System.EventHandler(this.rdPopup_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(71, 74);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Button";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(71, 182);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Button2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 265);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rdPopup);
            this.Controls.Add(this.rdFlat);
            this.Controls.Add(this.cbkMauNen);
            this.Controls.Add(this.cbkMauchu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbkMauchu;
        private System.Windows.Forms.CheckBox cbkMauNen;
        private System.Windows.Forms.RadioButton rdFlat;
        private System.Windows.Forms.RadioButton rdPopup;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

