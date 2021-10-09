
namespace RSTPWD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbpChange = new System.Windows.Forms.TabPage();
            this.txtCNewPwd2 = new System.Windows.Forms.TextBox();
            this.txtCNewPwd = new System.Windows.Forms.TextBox();
            this.txtCCurPwd = new System.Windows.Forms.TextBox();
            this.txtCUser = new System.Windows.Forms.TextBox();
            this.lblCNewPwd2 = new System.Windows.Forms.Label();
            this.lblCNewPwd = new System.Windows.Forms.Label();
            this.lblCCurPwd = new System.Windows.Forms.Label();
            this.lblCUser = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.tbpSet = new System.Windows.Forms.TabPage();
            this.txtSNewPwd2 = new System.Windows.Forms.TextBox();
            this.txtSNewPwd = new System.Windows.Forms.TextBox();
            this.txtSUser = new System.Windows.Forms.TextBox();
            this.lblSNewPwd2 = new System.Windows.Forms.Label();
            this.lblSNewPwd = new System.Windows.Forms.Label();
            this.lblSUser = new System.Windows.Forms.Label();
            this.lblAdmWarn = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tbpChange.SuspendLayout();
            this.tbpSet.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tbpChange);
            this.tabMain.Controls.Add(this.tbpSet);
            this.tabMain.Location = new System.Drawing.Point(12, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(298, 166);
            this.tabMain.TabIndex = 0;
            // 
            // tbpChange
            // 
            this.tbpChange.Controls.Add(this.txtCNewPwd2);
            this.tbpChange.Controls.Add(this.txtCNewPwd);
            this.tbpChange.Controls.Add(this.txtCCurPwd);
            this.tbpChange.Controls.Add(this.txtCUser);
            this.tbpChange.Controls.Add(this.lblCNewPwd2);
            this.tbpChange.Controls.Add(this.lblCNewPwd);
            this.tbpChange.Controls.Add(this.lblCCurPwd);
            this.tbpChange.Controls.Add(this.lblCUser);
            this.tbpChange.Controls.Add(this.btnChange);
            this.tbpChange.Location = new System.Drawing.Point(4, 22);
            this.tbpChange.Name = "tbpChange";
            this.tbpChange.Padding = new System.Windows.Forms.Padding(3);
            this.tbpChange.Size = new System.Drawing.Size(290, 140);
            this.tbpChange.TabIndex = 0;
            this.tbpChange.Text = "Change Password";
            this.tbpChange.UseVisualStyleBackColor = true;
            // 
            // txtCNewPwd2
            // 
            this.txtCNewPwd2.Location = new System.Drawing.Point(103, 84);
            this.txtCNewPwd2.Name = "txtCNewPwd2";
            this.txtCNewPwd2.PasswordChar = '*';
            this.txtCNewPwd2.Size = new System.Drawing.Size(181, 20);
            this.txtCNewPwd2.TabIndex = 4;
            // 
            // txtCNewPwd
            // 
            this.txtCNewPwd.Location = new System.Drawing.Point(103, 58);
            this.txtCNewPwd.Name = "txtCNewPwd";
            this.txtCNewPwd.PasswordChar = '*';
            this.txtCNewPwd.Size = new System.Drawing.Size(181, 20);
            this.txtCNewPwd.TabIndex = 3;
            // 
            // txtCCurPwd
            // 
            this.txtCCurPwd.Location = new System.Drawing.Point(103, 32);
            this.txtCCurPwd.Name = "txtCCurPwd";
            this.txtCCurPwd.PasswordChar = '*';
            this.txtCCurPwd.Size = new System.Drawing.Size(181, 20);
            this.txtCCurPwd.TabIndex = 2;
            // 
            // txtCUser
            // 
            this.txtCUser.Location = new System.Drawing.Point(103, 6);
            this.txtCUser.Name = "txtCUser";
            this.txtCUser.Size = new System.Drawing.Size(181, 20);
            this.txtCUser.TabIndex = 1;
            // 
            // lblCNewPwd2
            // 
            this.lblCNewPwd2.AutoSize = true;
            this.lblCNewPwd2.Location = new System.Drawing.Point(6, 87);
            this.lblCNewPwd2.Name = "lblCNewPwd2";
            this.lblCNewPwd2.Size = new System.Drawing.Size(91, 13);
            this.lblCNewPwd2.TabIndex = 4;
            this.lblCNewPwd2.Text = "Confirm Password";
            // 
            // lblCNewPwd
            // 
            this.lblCNewPwd.AutoSize = true;
            this.lblCNewPwd.Location = new System.Drawing.Point(6, 61);
            this.lblCNewPwd.Name = "lblCNewPwd";
            this.lblCNewPwd.Size = new System.Drawing.Size(78, 13);
            this.lblCNewPwd.TabIndex = 3;
            this.lblCNewPwd.Text = "New Password";
            // 
            // lblCCurPwd
            // 
            this.lblCCurPwd.AutoSize = true;
            this.lblCCurPwd.Location = new System.Drawing.Point(6, 35);
            this.lblCCurPwd.Name = "lblCCurPwd";
            this.lblCCurPwd.Size = new System.Drawing.Size(90, 13);
            this.lblCCurPwd.TabIndex = 2;
            this.lblCCurPwd.Text = "Current Password";
            // 
            // lblCUser
            // 
            this.lblCUser.AutoSize = true;
            this.lblCUser.Location = new System.Drawing.Point(6, 9);
            this.lblCUser.Name = "lblCUser";
            this.lblCUser.Size = new System.Drawing.Size(55, 13);
            this.lblCUser.TabIndex = 1;
            this.lblCUser.Text = "Username";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(6, 110);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(278, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbpSet
            // 
            this.tbpSet.Controls.Add(this.txtSNewPwd2);
            this.tbpSet.Controls.Add(this.txtSNewPwd);
            this.tbpSet.Controls.Add(this.txtSUser);
            this.tbpSet.Controls.Add(this.lblSNewPwd2);
            this.tbpSet.Controls.Add(this.lblSNewPwd);
            this.tbpSet.Controls.Add(this.lblSUser);
            this.tbpSet.Controls.Add(this.lblAdmWarn);
            this.tbpSet.Controls.Add(this.btnSet);
            this.tbpSet.Location = new System.Drawing.Point(4, 22);
            this.tbpSet.Name = "tbpSet";
            this.tbpSet.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSet.Size = new System.Drawing.Size(290, 140);
            this.tbpSet.TabIndex = 1;
            this.tbpSet.Text = "Set Password";
            this.tbpSet.UseVisualStyleBackColor = true;
            // 
            // txtSNewPwd2
            // 
            this.txtSNewPwd2.Location = new System.Drawing.Point(103, 84);
            this.txtSNewPwd2.Name = "txtSNewPwd2";
            this.txtSNewPwd2.PasswordChar = '*';
            this.txtSNewPwd2.Size = new System.Drawing.Size(181, 20);
            this.txtSNewPwd2.TabIndex = 3;
            // 
            // txtSNewPwd
            // 
            this.txtSNewPwd.Location = new System.Drawing.Point(103, 58);
            this.txtSNewPwd.Name = "txtSNewPwd";
            this.txtSNewPwd.PasswordChar = '*';
            this.txtSNewPwd.Size = new System.Drawing.Size(181, 20);
            this.txtSNewPwd.TabIndex = 2;
            // 
            // txtSUser
            // 
            this.txtSUser.Location = new System.Drawing.Point(103, 32);
            this.txtSUser.Name = "txtSUser";
            this.txtSUser.Size = new System.Drawing.Size(181, 20);
            this.txtSUser.TabIndex = 1;
            // 
            // lblSNewPwd2
            // 
            this.lblSNewPwd2.AutoSize = true;
            this.lblSNewPwd2.Location = new System.Drawing.Point(6, 87);
            this.lblSNewPwd2.Name = "lblSNewPwd2";
            this.lblSNewPwd2.Size = new System.Drawing.Size(91, 13);
            this.lblSNewPwd2.TabIndex = 13;
            this.lblSNewPwd2.Text = "Confirm Password";
            // 
            // lblSNewPwd
            // 
            this.lblSNewPwd.AutoSize = true;
            this.lblSNewPwd.Location = new System.Drawing.Point(6, 61);
            this.lblSNewPwd.Name = "lblSNewPwd";
            this.lblSNewPwd.Size = new System.Drawing.Size(78, 13);
            this.lblSNewPwd.TabIndex = 12;
            this.lblSNewPwd.Text = "New Password";
            // 
            // lblSUser
            // 
            this.lblSUser.AutoSize = true;
            this.lblSUser.Location = new System.Drawing.Point(6, 35);
            this.lblSUser.Name = "lblSUser";
            this.lblSUser.Size = new System.Drawing.Size(55, 13);
            this.lblSUser.TabIndex = 11;
            this.lblSUser.Text = "Username";
            // 
            // lblAdmWarn
            // 
            this.lblAdmWarn.AutoSize = true;
            this.lblAdmWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmWarn.ForeColor = System.Drawing.Color.Red;
            this.lblAdmWarn.Location = new System.Drawing.Point(11, 9);
            this.lblAdmWarn.Name = "lblAdmWarn";
            this.lblAdmWarn.Size = new System.Drawing.Size(269, 13);
            this.lblAdmWarn.TabIndex = 10;
            this.lblAdmWarn.Text = "You must be a domain administrator to do this!";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(6, 110);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(278, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set Password";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniInfo});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(322, 24);
            this.mnuMenu.TabIndex = 1;
            // 
            // mniInfo
            // 
            this.mniInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAbout});
            this.mniInfo.Name = "mniInfo";
            this.mniInfo.Size = new System.Drawing.Size(40, 20);
            this.mniInfo.Text = "Info";
            // 
            // mniAbout
            // 
            this.mniAbout.Name = "mniAbout";
            this.mniAbout.Size = new System.Drawing.Size(180, 22);
            this.mniAbout.Text = "About";
            this.mniAbout.Click += new System.EventHandler(this.mniAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 206);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.mnuMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmMain";
            this.Text = "RSTPWD";
            this.tabMain.ResumeLayout(false);
            this.tbpChange.ResumeLayout(false);
            this.tbpChange.PerformLayout();
            this.tbpSet.ResumeLayout(false);
            this.tbpSet.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbpChange;
        private System.Windows.Forms.TabPage tbpSet;
        private System.Windows.Forms.TextBox txtCNewPwd2;
        private System.Windows.Forms.TextBox txtCNewPwd;
        private System.Windows.Forms.TextBox txtCCurPwd;
        private System.Windows.Forms.TextBox txtCUser;
        private System.Windows.Forms.Label lblCNewPwd2;
        private System.Windows.Forms.Label lblCNewPwd;
        private System.Windows.Forms.Label lblCCurPwd;
        private System.Windows.Forms.Label lblCUser;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtSNewPwd2;
        private System.Windows.Forms.TextBox txtSNewPwd;
        private System.Windows.Forms.TextBox txtSUser;
        private System.Windows.Forms.Label lblSNewPwd2;
        private System.Windows.Forms.Label lblSNewPwd;
        private System.Windows.Forms.Label lblSUser;
        private System.Windows.Forms.Label lblAdmWarn;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniInfo;
        private System.Windows.Forms.ToolStripMenuItem mniAbout;
    }
}

