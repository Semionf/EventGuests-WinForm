namespace frmCategory
{
    partial class frmCategories
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
            this.dgvAllFoods = new System.Windows.Forms.DataGridView();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.dgvCurrentPerson = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtFood = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllFoods
            // 
            this.dgvAllFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllFoods.Location = new System.Drawing.Point(102, 92);
            this.dgvAllFoods.Name = "dgvAllFoods";
            this.dgvAllFoods.RowHeadersWidth = 51;
            this.dgvAllFoods.Size = new System.Drawing.Size(562, 169);
            this.dgvAllFoods.TabIndex = 0;
            this.dgvAllFoods.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllFoods_CellContentDoubleClick);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(224, 34);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(161, 32);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "שם קטגוריה";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(425, 34);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(139, 32);
            this.lblGuestName.TabIndex = 3;
            this.lblGuestName.Text = "שם האורח";
            // 
            // dgvCurrentPerson
            // 
            this.dgvCurrentPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentPerson.Location = new System.Drawing.Point(102, 368);
            this.dgvCurrentPerson.Name = "dgvCurrentPerson";
            this.dgvCurrentPerson.RowHeadersWidth = 51;
            this.dgvCurrentPerson.Size = new System.Drawing.Size(562, 169);
            this.dgvCurrentPerson.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(161, 299);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 41);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(456, 296);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(123, 46);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "הוספת מאכל";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(230, 574);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(102, 41);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "<<<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(431, 574);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 41);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">>>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(303, 310);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(125, 20);
            this.txtFood.TabIndex = 9;
            this.txtFood.Visible = false;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvCurrentPerson);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.dgvAllFoods);
            this.Name = "frmCategories";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllFoods;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.DataGridView dgvCurrentPerson;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtFood;
    }
}

