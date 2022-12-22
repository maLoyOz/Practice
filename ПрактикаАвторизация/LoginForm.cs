using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ПрактикаАвторизация.DataSet2TableAdapters;

namespace ПрактикаАвторизация
{
    public partial class LoginForm : Form
    {
        public bool loginFlag { get; set; }   
        public int UserId { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            loginFlag = false;
        }

        private void metroButton_login_Click(object sender, EventArgs e)
        {
            DataSet2TableAdapters.UsersTableAdapter userAda = new DataSet2TableAdapters.UsersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPassword(metroTextBox_user.Text, metroTextBox_password.Text);

            if (dt.Rows.Count > 0) 
            {
                //valid
                MessageBox.Show("Login Ok");
                UserId = int.Parse(dt.Rows[0]["UserId"].ToString());
                loginFlag= true;
            }
            else
            {
                //invalid
                MessageBox.Show("Access Denied");
                loginFlag = false;
            }  

            Close();
        }
            
    }
}
