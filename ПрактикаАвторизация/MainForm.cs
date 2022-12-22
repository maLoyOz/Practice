using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ПрактикаАвторизация.DataSet2TableAdapters;

namespace ПрактикаАвторизация
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserId { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.ClassesTBL". При необходимости она может быть перемещена или удалена.

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (loggedIn == 0)
            {
                //Open Login Form
                LoginForm newLogin = new LoginForm();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {
                    Close();
                }
                else
                {
                    UserId = newLogin.UserId;
                    statlblUser.Text = UserId.ToString();
                    loggedIn = 1;

                    // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.ClassesTBL". При необходимости она может быть перемещена или удалена.
                    this.classesTBLTableAdapter.Fill(this.dataSet2.ClassesTBL);

                    classesTBLBindingSource.Filter = "UserId = ' " + UserId.ToString() + "'";
                }

            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FormAddClass addClass = new FormAddClass();
            addClass.UserId = this.UserId;
            addClass.ShowDialog();  
        }

      /*  
       *  private void metroButton3_Click_1(object sender, EventArgs e)
        {
            FormAddClass addclass = new FormAddClass();
            addclass.UserId = this.UserId;
            addclass.ShowDialog();


        }
      */

        private void metroButton4_Click(object sender, EventArgs e)
        {
            StudentsForm students = new StudentsForm();
            students.ClassName = metroComboBox1.Text;
            students.ClassId = (int)metroComboBox1.SelectedValue;

            students.ShowDialog();
        }

        private void metroButtonGet_Click(object sender, EventArgs e)
        {
            // check if records exists if yes load them for edit and if not create a reocrd for each student and load for edit
            AttendanceREcordsTBLTableAdapter ada = new AttendanceREcordsTBLTableAdapter();
            DataTable dt = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

            if(dt.Rows.Count > 0)
            {
                //we have records so we can edit

                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }
            else
            {
                // create a record for each student
                //Get the calss students list

                StudentsTBLTableAdapter students_adapter = new StudentsTBLTableAdapter();

                DataTable dt_Students = students_adapter.GetDataByClassId((int)metroComboBox1.SelectedValue);
                
                foreach(DataRow row in dt_Students.Rows) 
                {
                    //Insert a new record fir this student 

                    ada.InsertQuery((int)row[0], (int)metroComboBox1.SelectedValue, dateTimePicker1.Text, "", row[1].ToString(), metroComboBox1.Text);                  
              
                }

                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AttendanceREcordsTBLTableAdapter ada = new AttendanceREcordsTBLTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                }

            }

            DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AttendanceREcordsTBLTableAdapter ada = new AttendanceREcordsTBLTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery("", row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                }

            }

            DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            //get students 

            StudentsTBLTableAdapter students_adapter = new StudentsTBLTableAdapter();

            DataTable dt_Students = students_adapter.GetDataByClassId((int)metroComboBox1.SelectedValue);
            //loop through students and get the values

            AttendanceREcordsTBLTableAdapter ada = new AttendanceREcordsTBLTableAdapter();

            int p = 0;
            int A = 0;
            int L = 0;
            int E = 0;

            foreach (DataRow row in dt_Students.Rows)
            {
                //presence count
                p = (int)ada.GetDataByReport(Convert.ToDecimal(dateTimePicker2.Value.Month) , row[1].ToString(), "present").Rows[0][6];

                // Absence

                A = (int)ada.GetDataByReport(Convert.ToDecimal(dateTimePicker2.Value.Month) , row[1].ToString(), "absent").Rows[0][6];
                
                //late
                
                L = (int)ada.GetDataByReport(Convert.ToDecimal(dateTimePicker2.Value.Month) , row[1].ToString(), "late").Rows[0][6];
                
                //Execuse

                E = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "execused").Rows[0][6];

                ListViewItem litem = new ListViewItem();
                litem.Text = row[1].ToString();
                litem.SubItems.Add(p.ToString());
                litem.SubItems.Add(A.ToString());
                litem.SubItems.Add(L.ToString());
                litem.SubItems.Add(E.ToString());
                listView1.Items.Add(litem);
            }



            //add to listview
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }

    }
}
