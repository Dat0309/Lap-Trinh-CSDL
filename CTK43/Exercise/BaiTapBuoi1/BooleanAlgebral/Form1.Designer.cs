
namespace BooleanAlgebral
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.benClose = new System.Windows.Forms.Button();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbResult = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(324, 47);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(45, 22);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "A^B";
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(26, 157);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(216, 34);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New operation";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(313, 157);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 34);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // benClose
            // 
            this.benClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.benClose.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benClose.Location = new System.Drawing.Point(26, 207);
            this.benClose.Name = "benClose";
            this.benClose.Size = new System.Drawing.Size(362, 29);
            this.benClose.TabIndex = 8;
            this.benClose.Text = "Close";
            this.benClose.UseVisualStyleBackColor = true;
            this.benClose.Click += new System.EventHandler(this.benClose_Click);
            // 
            // cbA
            // 
            this.cbA.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbA.AutoSize = true;
            this.cbA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbA.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA.Location = new System.Drawing.Point(26, 91);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(56, 29);
            this.cbA.TabIndex = 9;
            this.cbA.Text = "False";
            this.cbA.UseVisualStyleBackColor = true;
            this.cbA.CheckedChanged += new System.EventHandler(this.cbA_CheckedChanged);
            // 
            // cbB
            // 
            this.cbB.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbB.AutoSize = true;
            this.cbB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbB.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB.Location = new System.Drawing.Point(186, 91);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(56, 29);
            this.cbB.TabIndex = 10;
            this.cbB.Text = "False";
            this.cbB.UseVisualStyleBackColor = true;
            this.cbB.CheckedChanged += new System.EventHandler(this.cbB_CheckedChanged);
            // 
            // cbResult
            // 
            this.cbResult.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbResult.AutoSize = true;
            this.cbResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbResult.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResult.Location = new System.Drawing.Point(313, 91);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(56, 29);
            this.cbResult.TabIndex = 11;
            this.cbResult.Text = "False";
            this.cbResult.UseVisualStyleBackColor = true;
            this.cbResult.CheckedChanged += new System.EventHandler(this.cbResult_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 266);
            this.Controls.Add(this.cbResult);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.cbA);
            this.Controls.Add(this.benClose);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button benClose;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbResult;
    }
}

