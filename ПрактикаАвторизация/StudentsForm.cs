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
    public partial class StudentsForm : Form
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.StudentsTBL". При необходимости она может быть перемещена или удалена.
            this.studentsTBLTableAdapter.Fill(this.dataSet2.StudentsTBL);
            labelClassId.Text = ClassId.ToString();
            labelClassName.Text = ClassName.ToString();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.studentsTBLBindingSource.EndEdit();
            this.studentsTBLTableAdapter.Update(dataSet2.StudentsTBL);
        }
    }
}
