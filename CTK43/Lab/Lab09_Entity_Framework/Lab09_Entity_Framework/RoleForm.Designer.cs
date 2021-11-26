namespace Lab09_Entity_Framework
{
    partial class RoleForm
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
            this.lvRole = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvRole
            // 
            this.lvRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvRole.FullRowSelect = true;
            this.lvRole.GridLines = true;
            this.lvRole.HideSelection = false;
            this.lvRole.Location = new System.Drawing.Point(12, 44);
            this.lvRole.MultiSelect = false;
            this.lvRole.Name = "lvRole";
            this.lvRole.Size = new System.Drawing.Size(296, 196);
            this.lvRole.TabIndex = 0;
            this.lvRole.UseCompatibleStateImageBehavior = false;
            this.lvRole.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên quyền";
            this.columnHeader2.Width = 150;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRole.Image = global::Lab09_Entity_Framework.Properties.Resources.icons8_add_24px;
            this.btnAddRole.Location = new System.Drawing.Point(265, 3);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(44, 35);
            this.btnAddRole.TabIndex = 1;
            this.btnAddRole.UseVisualStyleBackColor = true;
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 252);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.lvRole);
            this.Name = "RoleForm";
            this.Text = "RoleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRole;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAddRole;
    }
}