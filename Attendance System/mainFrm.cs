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
    public partial class mainFrm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserID { get; set; }

        public mainFrm()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void mainFrm_Activated(object sender, EventArgs e)
        {
            if (loggedIn == 0)
            {
                //Open Login Form
                loginFrm newLogin = new loginFrm();
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
            addStudents.ShowDialog();
            addStudents.ClassName = metroComboBox1.Text;
            addStudents.ClassID = (int)metroComboBox1.SelectedValue;

        }
    }
}
