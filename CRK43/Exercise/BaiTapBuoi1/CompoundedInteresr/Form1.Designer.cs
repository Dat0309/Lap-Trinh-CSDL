
namespace CompoundedInteresr
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrin = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdMon = new System.Windows.Forms.RadioButton();
            this.rdQua = new System.Windows.Forms.RadioButton();
            this.rdSen = new System.Windows.Forms.RadioButton();
            this.rdAnn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInteresResult = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPer);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtPrin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Setup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdAnn);
            this.groupBox2.Controls.Add(this.rdSen);
            this.groupBox2.Controls.Add(this.rdQua);
            this.groupBox2.Controls.Add(this.rdMon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(401, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "\tCompound Frequency";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.txtInteresResult);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(688, 48);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 34);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periods:";
            // 
            // txtPrin
            // 
            this.txtPrin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrin.Location = new System.Drawing.Point(133, 35);
            this.txtPrin.Name = "txtPrin";
            this.txtPrin.Size = new System.Drawing.Size(128, 25);
            this.txtPrin.TabIndex = 3;
            this.txtPrin.Text = "0.00";
            this.txtPrin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(133, 105);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(128, 25);
            this.txtRate.TabIndex = 4;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPer
            // 
            this.txtPer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPer.Location = new System.Drawing.Point(133, 175);
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(128, 25);
            this.txtPer.TabIndex = 5;
            this.txtPer.Text = "1";
            this.txtPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Year";
            // 
            // rdMon
            // 
            this.rdMon.AutoSize = true;
            this.rdMon.Checked = true;
            this.rdMon.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMon.Location = new System.Drawing.Point(63, 33);
            this.rdMon.Name = "rdMon";
            this.rdMon.Size = new System.Drawing.Size(79, 23);
            this.rdMon.TabIndex = 0;
            this.rdMon.TabStop = true;
            this.rdMon.Text = "Monthly";
            this.rdMon.UseVisualStyleBackColor = true;
            // 
            // rdQua
            // 
            this.rdQua.AutoSize = true;
            this.rdQua.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdQua.Location = new System.Drawing.Point(63, 80);
            this.rdQua.Name = "rdQua";
            this.rdQua.Size = new System.Drawing.Size(85, 23);
            this.rdQua.TabIndex = 1;
            this.rdQua.TabStop = true;
            this.rdQua.Text = "Quarterly";
            this.rdQua.UseVisualStyleBackColor = true;
            // 
            // rdSen
            // 
            this.rdSen.AutoSize = true;
            this.rdSen.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSen.Location = new System.Drawing.Point(63, 124);
            this.rdSen.Name = "rdSen";
            this.rdSen.Size = new System.Drawing.Size(108, 23);
            this.rdSen.TabIndex = 2;
            this.rdSen.TabStop = true;
            this.rdSen.Text = "Semiannually";
            this.rdSen.UseVisualStyleBackColor = true;
            // 
            // rdAnn
            // 
            this.rdAnn.AutoSize = true;
            this.rdAnn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAnn.Location = new System.Drawing.Point(63, 171);
            this.rdAnn.Name = "rdAnn";
            this.rdAnn.Size = new System.Drawing.Size(80, 23);
            this.rdAnn.TabIndex = 3;
            this.rdAnn.TabStop = true;
            this.rdAnn.Text = "Annually";
            this.rdAnn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Interest Rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "FutureValue:";
            // 
            // txtInteresResult
            // 
            this.txtInteresResult.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteresResult.Location = new System.Drawing.Point(133, 54);
            this.txtInteresResult.Name = "txtInteresResult";
            this.txtInteresResult.ReadOnly = true;
            this.txtInteresResult.Size = new System.Drawing.Size(128, 25);
            this.txtInteresResult.TabIndex = 4;
            this.txtInteresResult.Text = "0.00";
            this.txtInteresResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(478, 57);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(128, 25);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(688, 102);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Compound Interest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtPrin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdAnn;
        private System.Windows.Forms.RadioButton rdSen;
        private System.Windows.Forms.RadioButton rdQua;
        private System.Windows.Forms.RadioButton rdMon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtInteresResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}

