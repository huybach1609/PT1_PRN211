using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class FormLogin : Form
    {
        private string user;
        private string pass;

        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = user;
            txtPassword.Text = pass;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Email or password must not null","Announcement");
                return;

            }
            if (txtEmail.Text == user && txtPassword.Text == pass)
            {
                FormMemberManagerment form = new FormMemberManagerment();
                this.Hide();
                form.ShowDialog();
                txtEmail.Text = user;
                txtPassword.Text = pass;
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username, Password", "Announcement");
                return;
            }

        }


        private void btnCancle_Click(object sender, EventArgs e) => Close();

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "exit", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
