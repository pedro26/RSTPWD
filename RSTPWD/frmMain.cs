using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace RSTPWD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private PrincipalContext getDomain()
        {
            PrincipalContext domain = null;

            try
            {
                domain = new PrincipalContext(ContextType.Domain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (domain);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int error = 0;
            bool validation = false;
            
            if (txtCNewPwd.Text != txtCNewPwd2.Text) error = 1;
            if (txtCNewPwd2.Text.Length <= 0) error = 2;
            if (txtCNewPwd.Text.Length <= 0) error = 3;
            if (txtCCurPwd.Text.Length <= 0) error = 4;
            if (txtCUser.Text.Length <= 0) error = 5;

            switch (error)
            {
                case 1:
                    MessageBox.Show("The new passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("You must confirm the new password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("The new password could not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("You must inform the current password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("You must inform the user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    using (PrincipalContext domain = getDomain())
                    {
                        if (domain != null)
                        {
                            using (UserPrincipal user = UserPrincipal.FindByIdentity(domain, IdentityType.SamAccountName, txtCUser.Text))
                            {
                                try
                                {
                                    user.ChangePassword(txtCCurPwd.Text, txtCNewPwd.Text);
                                    user.Save();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    validation = true;
                                }
                                if (!validation)
                                {
                                    MessageBox.Show("Password changed!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtCUser.Text = "";
                                    txtCCurPwd.Text = "";
                                    txtCNewPwd.Text = "";
                                    txtCNewPwd2.Text = "";
                                    txtCUser.Focus();
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int error = 0;
            bool validation = false;

            if (txtSNewPwd.Text != txtSNewPwd2.Text) error = 1;
            if (txtSNewPwd2.Text.Length <= 0) error = 2;
            if (txtSNewPwd.Text.Length <= 0) error = 3;
            if (txtSUser.Text.Length <= 0) error = 4;

            switch (error)
            {
                case 1:
                    MessageBox.Show("The passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("You must confirm the new password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("The password could not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("You must inform the user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    using (PrincipalContext domain = getDomain())
                    {
                        if (domain != null)
                        {
                            using (UserPrincipal user = UserPrincipal.FindByIdentity(domain, IdentityType.SamAccountName, txtSUser.Text))
                            {
                                try
                                {
                                    user.SetPassword(txtSNewPwd.Text);
                                    user.Save();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    validation = true;
                                }
                                if (!validation)
                                {
                                    MessageBox.Show("Password setted!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtSUser.Text = "";
                                    txtSNewPwd.Text = "";
                                    txtSNewPwd2.Text = "";
                                    txtSUser.Focus();
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void mniAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyleft (ɔ) 2021" + Environment.NewLine +
                            "Pedro Augusto Domingues" + Environment.NewLine +
                            "Contact: pedroaugusto2612@gmail.com",
                            "About",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
