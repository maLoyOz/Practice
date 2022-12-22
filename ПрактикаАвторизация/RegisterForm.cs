using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПрактикаАвторизация
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(Txtpass1.Text != Txtpass2.Text) 
            {
                MessageBox.Show("Passwords dont match");
                return;
            }
            
            
            
            DataSet2TableAdapters.UsersTableAdapter ada = new DataSet2TableAdapters.UsersTableAdapter();
            ada.InsertQuery(TxtUser.Text, Txtpass1.Text);
            MessageBox.Show("Registration Succesfull");
        }
    }
}
