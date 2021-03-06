﻿namespace Attendance_System
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonRegister = new MetroFramework.Controls.MetroButton();
            this.metroButtonGet = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddStudents = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddClass = new MetroFramework.Controls.MetroButton();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceRecordsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Attendance_System.DataSet1();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.classesTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classesTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.classesTBLTableAdapter = new Attendance_System.DataSet1TableAdapters.ClassesTBLTableAdapter();
            this.attendanceRecordsTBLTableAdapter = new Attendance_System.DataSet1TableAdapters.AttendanceRecordsTBLTableAdapter();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecordsTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesTBLBindingSource1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesTBLBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(760, 491);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButtonRegister);
            this.metroTabPage1.Controls.Add(this.metroButtonGet);
            this.metroTabPage1.Controls.Add(this.metroButtonAddStudents);
            this.metroTabPage1.Controls.Add(this.metroButtonAddClass);
            this.metroTabPage1.Controls.Add(this.metroButtonClear);
            this.metroTabPage1.Controls.Add(this.metroButtonSave);
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Controls.Add(this.lblSelectDate);
            this.metroTabPage1.Controls.Add(this.lblSelectClass);
            this.metroTabPage1.Controls.Add(this.dateTimePicker1);
            this.metroTabPage1.Controls.Add(this.metroComboBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 452);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Attendance";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroButtonRegister
            // 
            this.metroButtonRegister.Location = new System.Drawing.Point(671, 408);
            this.metroButtonRegister.Name = "metroButtonRegister";
            this.metroButtonRegister.Size = new System.Drawing.Size(85, 23);
            this.metroButtonRegister.TabIndex = 12;
            this.metroButtonRegister.Text = "Register";
            this.metroButtonRegister.Click += new System.EventHandler(this.metroButtonRegister_Click);
            // 
            // metroButtonGet
            // 
            this.metroButtonGet.Location = new System.Drawing.Point(419, 40);
            this.metroButtonGet.Name = "metroButtonGet";
            this.metroButtonGet.Size = new System.Drawing.Size(75, 23);
            this.metroButtonGet.TabIndex = 11;
            this.metroButtonGet.Text = "Get Values";
            this.metroButtonGet.Click += new System.EventHandler(this.metroButtonGet_Click);
            // 
            // metroButtonAddStudents
            // 
            this.metroButtonAddStudents.Location = new System.Drawing.Point(654, 66);
            this.metroButtonAddStudents.Name = "metroButtonAddStudents";
            this.metroButtonAddStudents.Size = new System.Drawing.Size(85, 23);
            this.metroButtonAddStudents.TabIndex = 10;
            this.metroButtonAddStudents.Text = "Add Students";
            this.metroButtonAddStudents.Click += new System.EventHandler(this.metroButtonAddStudents_Click);
            // 
            // metroButtonAddClass
            // 
            this.metroButtonAddClass.Location = new System.Drawing.Point(654, 37);
            this.metroButtonAddClass.Name = "metroButtonAddClass";
            this.metroButtonAddClass.Size = new System.Drawing.Size(85, 23);
            this.metroButtonAddClass.TabIndex = 9;
            this.metroButtonAddClass.Text = "Add Class";
            this.metroButtonAddClass.Click += new System.EventHandler(this.metroButtonAddClass_Click);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(356, 115);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(75, 23);
            this.metroButtonClear.TabIndex = 8;
            this.metroButtonClear.Text = "Clear";
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(356, 86);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSave.TabIndex = 7;
            this.metroButtonSave.Text = "Save";
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceRecordsTBLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 322);
            this.dataGridView1.TabIndex = 6;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // attendanceRecordsTBLBindingSource
            // 
            this.attendanceRecordsTBLBindingSource.DataMember = "AttendanceRecordsTBL";
            this.attendanceRecordsTBLBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Location = new System.Drawing.Point(213, 21);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(66, 13);
            this.lblSelectDate.TabIndex = 5;
            this.lblSelectDate.Text = "Select Date:";
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Location = new System.Drawing.Point(3, 21);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(68, 13);
            this.lblSelectClass.TabIndex = 4;
            this.lblSelectClass.Text = "Select Class:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.classesTBLBindingSource1;
            this.metroComboBox1.DisplayMember = "ClassName";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(3, 40);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(187, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.ValueMember = "ClassID";
            // 
            // classesTBLBindingSource1
            // 
            this.classesTBLBindingSource1.DataMember = "ClassesTBL";
            this.classesTBLBindingSource1.DataSource = this.dataSet1;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.dateTimePicker2);
            this.metroTabPage2.Controls.Add(this.metroComboBox2);
            this.metroTabPage2.Controls.Add(this.listView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(752, 452);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Reports";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(451, 39);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Get Values";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Class:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(245, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.DataSource = this.classesTBLBindingSource1;
            this.metroComboBox2.DisplayMember = "ClassName";
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(3, 39);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(187, 29);
            this.metroComboBox2.TabIndex = 12;
            this.metroComboBox2.ValueMember = "ClassID";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(746, 292);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Presence";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Absences";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Late";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Excused";
            this.columnHeader5.Width = 102;
            // 
            // classesTBLBindingSource
            // 
            this.classesTBLBindingSource.DataMember = "ClassesTBL";
            this.classesTBLBindingSource.DataSource = this.dataSet1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statLblUser});
            this.statusStrip1.Location = new System.Drawing.Point(20, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "User:";
            // 
            // statLblUser
            // 
            this.statLblUser.Name = "statLblUser";
            this.statLblUser.Size = new System.Drawing.Size(12, 17);
            this.statLblUser.Text = "-";
            // 
            // classesTBLTableAdapter
            // 
            this.classesTBLTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceRecordsTBLTableAdapter
            // 
            this.attendanceRecordsTBLTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FrmMain";
            this.Text = "Attendance System";
            this.Activated += new System.EventHandler(this.mainFrm_Activated);
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecordsTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesTBLBindingSource1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesTBLBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButtonAddStudents;
        private MetroFramework.Controls.MetroButton metroButtonAddClass;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statLblUser;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource classesTBLBindingSource;
        private DataSet1TableAdapters.ClassesTBLTableAdapter classesTBLTableAdapter;
        private System.Windows.Forms.BindingSource classesTBLBindingSource1;
        private MetroFramework.Controls.MetroButton metroButtonGet;
        private System.Windows.Forms.BindingSource attendanceRecordsTBLBindingSource;
        private DataSet1TableAdapters.AttendanceRecordsTBLTableAdapter attendanceRecordsTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroButton metroButtonRegister;
    }
}

