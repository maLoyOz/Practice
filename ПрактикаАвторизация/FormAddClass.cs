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
    public partial class FormAddClass : Form
    {
        public int UserId { get; set; }
        public FormAddClass()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet2TableAdapters.ClassesTBLTableAdapter ada = new DataSet2TableAdapters.ClassesTBLTableAdapter();
            ada.Addclass(metroTextBox1.Text, UserId);
            Close();

        }
    }
}
