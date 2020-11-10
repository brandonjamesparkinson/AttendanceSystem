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
    public partial class FrmAddStudents : Form
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }

        public FrmAddStudents()
        {
            InitializeComponent();
        }

        private void FrmAddStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StudentsTBL' table. You can move, or remove it, as needed.
            this.studentsTBLTableAdapter.Fill(this.dataSet1.StudentsTBL);
            lblClassNameOverride.Text = ClassName.ToString();
            lblClassIDOverride.Text = ClassID.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.studentsTBLBindingSource.EndEdit();
            this.studentsTBLTableAdapter.Update(dataSet1.StudentsTBL);
        }
    }
}
