namespace EventGuests
{
    partial class frmHost
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
            this.lblHost = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.CategoryList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(327, 50);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(131, 16);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "מארח - הכנס קטגוריות";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(330, 92);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(128, 22);
            this.txtCategory.TabIndex = 1;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(351, 151);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(88, 29);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "הכנס";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.ItemHeight = 16;
            this.CategoryList.Location = new System.Drawing.Point(330, 226);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(128, 84);
            this.CategoryList.TabIndex = 3;
            // 
            // frmHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblHost);
            this.Name = "frmHost";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.ListBox CategoryList;
    }
}

