using Attendance_System.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserID { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void mainFrm_Activated(object sender, EventArgs e)
        {
            if (loggedIn == 0)
            {
                //Open Login Form
                FrmLogin newLogin = new FrmLogin();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {
                    Close();
                }
                else
                {
                    UserID = newLogin.UserID;
                    statLblUser.Text = UserID.ToString();
                    loggedIn = 1;

                    this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);

                    classesTBLBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";
                }

            }
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {


        }

        private void metroButtonAddClass_Click(object sender, EventArgs e)
        {
            FrmAddClass addClass = new FrmAddClass();
            addClass.UserID = this.UserID;
            addClass.ShowDialog();
        }

        private void metroButtonAddStudents_Click(object sender, EventArgs e)
        {
            FrmAddStudents addStudents = new FrmAddStudents();
            addStudents.ClassName = metroComboBox1.Text;
            addStudents.ClassID = (int)metroComboBox1.SelectedValue;
            addStudents.ShowDialog();
        }

        private void metroButtonGet_Click(object sender, EventArgs e)
        {
            AttendanceRecordsTBLTableAdapter ada = new AttendanceRecordsTBLTableAdapter();
            DataTable dt = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

            if (dt.Rows.Count > 0)
            {
                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }
            else
            {
                StudentsTBLTableAdapter students_adapter = new StudentsTBLTableAdapter();
                DataTable dt_Students = students_adapter.GetDataByClassID((int)metroComboBox1.SelectedValue);

                foreach (DataRow row in dt_Students.Rows)
                {
                    ada.InsertQuery((int)row[0], (int)metroComboBox1.SelectedValue, dateTimePicker1.Text, "", row[1].ToString(), metroComboBox1.Text);

                }

                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            AttendanceRecordsTBLTableAdapter ada = new AttendanceRecordsTBLTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                }
            }
        }
    }
}
