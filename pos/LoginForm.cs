using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace pos
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                lblError.Text = "Хэрэглэгчийн нэр болон нууц үгээ оруулна уу.";
                return;
            }

            string connectionString = "Data Source=pos.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Username=@user AND Password=@pass";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    object roleObj = cmd.ExecuteScalar();

                    if (roleObj != null)
                    {
                        string role = roleObj.ToString();
                        this.Hide();
                        MainForm mainForm = new MainForm(username, role);
                        mainForm.Show();
                    }
                    else
                    {
                        lblError.Text = "Нэвтрэх нэр эсвэл нууц үг буруу байна.";
                    }
                }
            }
        }
    }
}

