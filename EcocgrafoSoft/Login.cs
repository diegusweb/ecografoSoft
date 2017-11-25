using EcocgrafoSoft.Properties;
using EcocgrafoSoft.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcocgrafoSoft
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.InitializeResourceString();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }

        private void InitializeResourceString()
        {
            lblUserName.Text = Resources.Login_Username_Label_Text;
            lblPassword.Text = Resources.Login_Password_Label_Text;
            btnLogin.Text = Resources.Login_Login_Button_Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "demo" && txtPassword.Text.Trim() == "demo123")
            {
                var frmManage = new MainProgram();
                frmManage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    Resources.Login_Validation_Message,
                    Resources.Login_Validation_Message_Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
