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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void metroButtonAccept_Click(object sender, EventArgs e)
        {
            if (metroTextBoxPassword.Text != metroTextBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords Do Not Match!");
                return;
            }

            DataSet1TableAdapters.UsersTableAdapter ada = new DataSet1TableAdapters.UsersTableAdapter();
            ada.InsertQuery(metroTextBoxUserName.Text, metroTextBoxPassword.Text);
            MessageBox.Show("Registration Successful.");
            Close();
        }
    }
}
