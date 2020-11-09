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
        public mainFrm()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void mainFrm_Activated(object sender, EventArgs e)
        {
            if (loggedIn == 0)
            {
                // open login form
                loginFrm newLogin = new loginFrm();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {
                    Close();
                }
                else
                {
                    loggedIn = 1;
                }
            }
        }
    }
}
