using Gurtas.DAL.Context;
using Gurtas.DAL.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gurtas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var userId = Helper.Helper.UsernameControl(username);
            var user = Helper.Helper.GetUserById(userId);
            this.Tag = userId;

            if (userId != 0)
            {
                if (Helper.Helper.PasswordControl(userId, password))
                {
                    this.Hide();
                    if (user.Gender == "Erkek")
                    {
                        MessageBox.Show($"Hoş Geldiniz {user.Name} Bey", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (user.Gender == "Kadın")
                    {
                        MessageBox.Show($"Hoş Geldiniz {user.Name} Hanım", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show($"Hoş Geldiniz {user.Name}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    this.Close();
                }
                else
                {
                    this.Tag = 0;
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adını Yanlış Girdiniz. Lütfen Tekrar Deneyiniz.");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            var userId = Convert.ToInt32(this.Tag);
            if (userId == 0)
            {
                Application.Exit();
            }
            else if (userId != 0)
            {
                MainPage mainPage = new MainPage();
                mainPage.Tag = userId;
                mainPage.ShowDialog();
                this.Hide();
            }

        }
    }
}
