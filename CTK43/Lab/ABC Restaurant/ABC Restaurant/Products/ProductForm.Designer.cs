namespace ABC_Restaurant.Products
{
    partial class ProductForm
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cbbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(1, 41);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(845, 450);
            this.dgvProduct.TabIndex = 0;
            // 
            // cbbGroup
            // 
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(12, 7);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(151, 28);
            this.cbbGroup.TabIndex = 1;
            this.cbbGroup.SelectedIndexChanged += new System.EventHandler(this.cbbGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(259, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(332, 27);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 494);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbGroup);
            this.Controls.Add(this.dgvProduct);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProduct;
        private ComboBox cbbGroup;
        private Label label1;
        private TextBox txtSearch;
    }
}