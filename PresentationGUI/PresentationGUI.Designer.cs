namespace PresentationGUI
{
    partial class PresentationGUI
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
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.radBtnClub = new System.Windows.Forms.RadioButton();
            this.radBtnFratSor = new System.Windows.Forms.RadioButton();
            this.radBtnIntr = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFundedAmt = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFundedAmt = new System.Windows.Forms.TextBox();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.radBtnClub);
            this.grpBox.Controls.Add(this.radBtnFratSor);
            this.grpBox.Controls.Add(this.radBtnIntr);
            this.grpBox.ForeColor = System.Drawing.Color.Yellow;
            this.grpBox.Location = new System.Drawing.Point(0, 0);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(200, 100);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Select organizational type";
            // 
            // radBtnClub
            // 
            this.radBtnClub.AutoSize = true;
            this.radBtnClub.Location = new System.Drawing.Point(3, 62);
            this.radBtnClub.Name = "radBtnClub";
            this.radBtnClub.Size = new System.Drawing.Size(46, 17);
            this.radBtnClub.TabIndex = 2;
            this.radBtnClub.TabStop = true;
            this.radBtnClub.Text = "Club";
            this.radBtnClub.UseVisualStyleBackColor = true;
            this.radBtnClub.CheckedChanged += new System.EventHandler(this.radBtnClub_CheckedChanged);
            // 
            // radBtnFratSor
            // 
            this.radBtnFratSor.AutoSize = true;
            this.radBtnFratSor.Location = new System.Drawing.Point(3, 39);
            this.radBtnFratSor.Name = "radBtnFratSor";
            this.radBtnFratSor.Size = new System.Drawing.Size(108, 17);
            this.radBtnFratSor.TabIndex = 1;
            this.radBtnFratSor.TabStop = true;
            this.radBtnFratSor.Text = "Fraternity/Sorority";
            this.radBtnFratSor.UseVisualStyleBackColor = true;
            this.radBtnFratSor.CheckedChanged += new System.EventHandler(this.radBtnFratSor_CheckedChanged);
            // 
            // radBtnIntr
            // 
            this.radBtnIntr.AutoSize = true;
            this.radBtnIntr.Location = new System.Drawing.Point(3, 16);
            this.radBtnIntr.Name = "radBtnIntr";
            this.radBtnIntr.Size = new System.Drawing.Size(97, 17);
            this.radBtnIntr.TabIndex = 0;
            this.radBtnIntr.TabStop = true;
            this.radBtnIntr.Text = "Intramural team";
            this.radBtnIntr.UseVisualStyleBackColor = true;
            this.radBtnIntr.CheckedChanged += new System.EventHandler(this.radBtnIntr_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            // 
            // lblFundedAmt
            // 
            this.lblFundedAmt.AutoSize = true;
            this.lblFundedAmt.Location = new System.Drawing.Point(14, 189);
            this.lblFundedAmt.Name = "lblFundedAmt";
            this.lblFundedAmt.Size = new System.Drawing.Size(69, 13);
            this.lblFundedAmt.TabIndex = 2;
            this.lblFundedAmt.Text = "Funding Amt:";
            this.lblFundedAmt.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Visible = false;
            // 
            // txtFundedAmt
            // 
            this.txtFundedAmt.Location = new System.Drawing.Point(122, 182);
            this.txtFundedAmt.Name = "txtFundedAmt";
            this.txtFundedAmt.Size = new System.Drawing.Size(100, 20);
            this.txtFundedAmt.TabIndex = 4;
            this.txtFundedAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFundedAmt.Visible = false;
            // 
            // PresentationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtFundedAmt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblFundedAmt);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpBox);
            this.Name = "PresentationGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PresentationGUI_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton radBtnClub;
        private System.Windows.Forms.RadioButton radBtnFratSor;
        private System.Windows.Forms.RadioButton radBtnIntr;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFundedAmt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFundedAmt;
    }
}

