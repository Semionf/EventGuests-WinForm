namespace Guest
{
    partial class frmGuest
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.listGuests = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(256, 44);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(131, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "ברוכים הבאים";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(270, 88);
            this.lblGuestName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(79, 15);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "הכנס שם אורח";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(260, 130);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(82, 20);
            this.txtGuestName.TabIndex = 2;
            this.txtGuestName.TextChanged += new System.EventHandler(this.txtGuestName_TextChanged);
            this.txtGuestName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuestName_KeyPress);
            // 
            // listGuests
            // 
            this.listGuests.FormattingEnabled = true;
            this.listGuests.Location = new System.Drawing.Point(245, 177);
            this.listGuests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listGuests.Name = "listGuests";
            this.listGuests.Size = new System.Drawing.Size(104, 95);
            this.listGuests.TabIndex = 3;
            this.listGuests.SelectedIndexChanged += new System.EventHandler(this.listGuests_SelectedIndexChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(261, 300);
            this.OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(62, 35);
            this.OK.TabIndex = 4;
            this.OK.Text = "אישור";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // frmGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.listGuests);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGuest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.ListBox listGuests;
        private System.Windows.Forms.Button OK;
    }
}

