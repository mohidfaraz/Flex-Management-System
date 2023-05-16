using System.Security.Cryptography.X509Certificates;

namespace Group_10_22F_3388_22F_3846_FMS
{
    partial class studentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentForm));
            studentMainTab = new TabControl();
            homePageStd = new TabPage();
            genderBox = new TextBox();
            DepStdBox = new TextBox();
            bloodBoxStd = new TextBox();
            salaryLbl = new Label();
            AdressStdBox = new TextBox();
            label3 = new Label();
            QualificationStdBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ContactStdBox = new TextBox();
            label7 = new Label();
            LNameStdBox = new TextBox();
            label8 = new Label();
            FNameStdBox = new TextBox();
            label9 = new Label();
            viewAttendance = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            courseLblAtnd = new Label();
            courseBoxAtnd = new ComboBox();
            attendanceGrid = new DataGridView();
            viewMarks = new TabPage();
            marksGrid = new DataGridView();
            label1 = new Label();
            courseBoxMarks = new ComboBox();
            viewGrades = new TabPage();
            gradeGrid = new DataGridView();
            regCourses = new TabPage();
            courseGrid = new DataGridView();
            feeStatus = new TabPage();
            paidOrUnpaidLbl = new Label();
            label2 = new Label();
            logoutLBl = new Label();
            studentMainTab.SuspendLayout();
            homePageStd.SuspendLayout();
            viewAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).BeginInit();
            viewMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)marksGrid).BeginInit();
            viewGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradeGrid).BeginInit();
            regCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)courseGrid).BeginInit();
            feeStatus.SuspendLayout();
            SuspendLayout();
            // 
            // studentMainTab
            // 
            studentMainTab.Controls.Add(homePageStd);
            studentMainTab.Controls.Add(viewAttendance);
            studentMainTab.Controls.Add(viewMarks);
            studentMainTab.Controls.Add(viewGrades);
            studentMainTab.Controls.Add(regCourses);
            studentMainTab.Controls.Add(feeStatus);
            studentMainTab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            studentMainTab.Location = new Point(47, 70);
            studentMainTab.Margin = new Padding(3, 4, 3, 4);
            studentMainTab.Name = "studentMainTab";
            studentMainTab.SelectedIndex = 0;
            studentMainTab.Size = new Size(805, 476);
            studentMainTab.TabIndex = 1;
            // 
            // homePageStd
            // 
            homePageStd.BackColor = Color.WhiteSmoke;
            homePageStd.Controls.Add(genderBox);
            homePageStd.Controls.Add(DepStdBox);
            homePageStd.Controls.Add(bloodBoxStd);
            homePageStd.Controls.Add(salaryLbl);
            homePageStd.Controls.Add(AdressStdBox);
            homePageStd.Controls.Add(label3);
            homePageStd.Controls.Add(QualificationStdBox);
            homePageStd.Controls.Add(label4);
            homePageStd.Controls.Add(label5);
            homePageStd.Controls.Add(label6);
            homePageStd.Controls.Add(ContactStdBox);
            homePageStd.Controls.Add(label7);
            homePageStd.Controls.Add(LNameStdBox);
            homePageStd.Controls.Add(label8);
            homePageStd.Controls.Add(FNameStdBox);
            homePageStd.Controls.Add(label9);
            homePageStd.Location = new Point(4, 29);
            homePageStd.Margin = new Padding(3, 4, 3, 4);
            homePageStd.Name = "homePageStd";
            homePageStd.Size = new Size(797, 443);
            homePageStd.TabIndex = 5;
            homePageStd.Text = "Home Page";
            // 
            // genderBox
            // 
            genderBox.BackColor = Color.WhiteSmoke;
            genderBox.BorderStyle = BorderStyle.None;
            genderBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            genderBox.Location = new Point(542, 252);
            genderBox.Margin = new Padding(3, 4, 3, 4);
            genderBox.Name = "genderBox";
            genderBox.ReadOnly = true;
            genderBox.Size = new Size(151, 22);
            genderBox.TabIndex = 97;
            genderBox.TextChanged += genderBox_TextChanged;
            // 
            // DepStdBox
            // 
            DepStdBox.BackColor = Color.WhiteSmoke;
            DepStdBox.BorderStyle = BorderStyle.None;
            DepStdBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DepStdBox.Location = new Point(542, 134);
            DepStdBox.Margin = new Padding(3, 4, 3, 4);
            DepStdBox.Name = "DepStdBox";
            DepStdBox.ReadOnly = true;
            DepStdBox.Size = new Size(151, 22);
            DepStdBox.TabIndex = 96;
            // 
            // bloodBoxStd
            // 
            bloodBoxStd.BackColor = Color.WhiteSmoke;
            bloodBoxStd.BorderStyle = BorderStyle.None;
            bloodBoxStd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bloodBoxStd.Location = new Point(542, 191);
            bloodBoxStd.Margin = new Padding(3, 4, 3, 4);
            bloodBoxStd.Name = "bloodBoxStd";
            bloodBoxStd.ReadOnly = true;
            bloodBoxStd.Size = new Size(151, 22);
            bloodBoxStd.TabIndex = 95;
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            salaryLbl.Location = new Point(419, 190);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(111, 23);
            salaryLbl.TabIndex = 94;
            salaryLbl.Text = "Blood Group:";
            // 
            // AdressStdBox
            // 
            AdressStdBox.BackColor = Color.WhiteSmoke;
            AdressStdBox.BorderStyle = BorderStyle.None;
            AdressStdBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressStdBox.Location = new Point(228, 249);
            AdressStdBox.Margin = new Padding(3, 4, 3, 4);
            AdressStdBox.Multiline = true;
            AdressStdBox.Name = "AdressStdBox";
            AdressStdBox.ReadOnly = true;
            AdressStdBox.Size = new Size(151, 59);
            AdressStdBox.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 250);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 92;
            label3.Text = "Address:";
            // 
            // QualificationStdBox
            // 
            QualificationStdBox.BackColor = Color.WhiteSmoke;
            QualificationStdBox.BorderStyle = BorderStyle.None;
            QualificationStdBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            QualificationStdBox.Location = new Point(228, 196);
            QualificationStdBox.Margin = new Padding(3, 4, 3, 4);
            QualificationStdBox.Name = "QualificationStdBox";
            QualificationStdBox.ReadOnly = true;
            QualificationStdBox.Size = new Size(151, 22);
            QualificationStdBox.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(107, 189);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 90;
            label4.Text = "Qualification:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(419, 251);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 89;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(419, 138);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 88;
            label6.Text = "Department:";
            // 
            // ContactStdBox
            // 
            ContactStdBox.BackColor = Color.WhiteSmoke;
            ContactStdBox.BorderStyle = BorderStyle.None;
            ContactStdBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ContactStdBox.Location = new Point(228, 139);
            ContactStdBox.Margin = new Padding(3, 4, 3, 4);
            ContactStdBox.Name = "ContactStdBox";
            ContactStdBox.ReadOnly = true;
            ContactStdBox.Size = new Size(151, 22);
            ContactStdBox.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(107, 137);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 86;
            label7.Text = "Contact No:";
            // 
            // LNameStdBox
            // 
            LNameStdBox.BackColor = Color.WhiteSmoke;
            LNameStdBox.BorderStyle = BorderStyle.None;
            LNameStdBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNameStdBox.Location = new Point(542, 86);
            LNameStdBox.Margin = new Padding(3, 4, 3, 4);
            LNameStdBox.Name = "LNameStdBox";
            LNameStdBox.ReadOnly = true;
            LNameStdBox.Size = new Size(151, 22);
            LNameStdBox.TabIndex = 85;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(419, 87);
            label8.Name = "label8";
            label8.Size = new Size(95, 23);
            label8.TabIndex = 84;
            label8.Text = "Last Name:";
            // 
            // FNameStdBox
            // 
            FNameStdBox.BackColor = Color.WhiteSmoke;
            FNameStdBox.BorderStyle = BorderStyle.None;
            FNameStdBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FNameStdBox.Location = new Point(228, 85);
            FNameStdBox.Margin = new Padding(3, 4, 3, 4);
            FNameStdBox.Name = "FNameStdBox";
            FNameStdBox.ReadOnly = true;
            FNameStdBox.Size = new Size(151, 22);
            FNameStdBox.TabIndex = 83;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(107, 84);
            label9.Name = "label9";
            label9.Size = new Size(97, 23);
            label9.TabIndex = 82;
            label9.Text = "First Name:";
            // 
            // viewAttendance
            // 
            viewAttendance.BackColor = Color.WhiteSmoke;
            viewAttendance.Controls.Add(dateTimePicker1);
            viewAttendance.Controls.Add(courseLblAtnd);
            viewAttendance.Controls.Add(courseBoxAtnd);
            viewAttendance.Controls.Add(attendanceGrid);
            viewAttendance.Location = new Point(4, 29);
            viewAttendance.Margin = new Padding(3, 4, 3, 4);
            viewAttendance.Name = "viewAttendance";
            viewAttendance.Padding = new Padding(11, 13, 11, 13);
            viewAttendance.Size = new Size(797, 443);
            viewAttendance.TabIndex = 0;
            viewAttendance.Text = "View Attendance";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(305, 112);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // courseLblAtnd
            // 
            courseLblAtnd.AutoSize = true;
            courseLblAtnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            courseLblAtnd.Location = new Point(271, 56);
            courseLblAtnd.Name = "courseLblAtnd";
            courseLblAtnd.Size = new Size(61, 20);
            courseLblAtnd.TabIndex = 2;
            courseLblAtnd.Text = "Course:";
            // 
            // courseBoxAtnd
            // 
            courseBoxAtnd.FormattingEnabled = true;
            courseBoxAtnd.Location = new Point(333, 52);
            courseBoxAtnd.Margin = new Padding(3, 4, 3, 4);
            courseBoxAtnd.Name = "courseBoxAtnd";
            courseBoxAtnd.Size = new Size(163, 28);
            courseBoxAtnd.TabIndex = 1;
            courseBoxAtnd.SelectedIndexChanged += courseBoxAtnd_SelectedIndexChanged;
            // 
            // attendanceGrid
            // 
            attendanceGrid.AllowUserToAddRows = false;
            attendanceGrid.AllowUserToDeleteRows = false;
            attendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendanceGrid.Location = new Point(25, 171);
            attendanceGrid.Margin = new Padding(3, 4, 3, 4);
            attendanceGrid.Name = "attendanceGrid";
            attendanceGrid.ReadOnly = true;
            attendanceGrid.RowHeadersWidth = 51;
            attendanceGrid.RowTemplate.Height = 25;
            attendanceGrid.Size = new Size(744, 236);
            attendanceGrid.TabIndex = 0;
            // 
            // viewMarks
            // 
            viewMarks.BackColor = Color.WhiteSmoke;
            viewMarks.Controls.Add(marksGrid);
            viewMarks.Controls.Add(label1);
            viewMarks.Controls.Add(courseBoxMarks);
            viewMarks.ForeColor = SystemColors.ActiveCaptionText;
            viewMarks.Location = new Point(4, 29);
            viewMarks.Margin = new Padding(3, 4, 3, 4);
            viewMarks.Name = "viewMarks";
            viewMarks.Padding = new Padding(11, 13, 11, 13);
            viewMarks.Size = new Size(797, 443);
            viewMarks.TabIndex = 1;
            viewMarks.Text = "View Marks";
            // 
            // marksGrid
            // 
            marksGrid.AllowUserToAddRows = false;
            marksGrid.AllowUserToDeleteRows = false;
            marksGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            marksGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            marksGrid.Location = new Point(25, 153);
            marksGrid.Margin = new Padding(3, 4, 3, 4);
            marksGrid.Name = "marksGrid";
            marksGrid.ReadOnly = true;
            marksGrid.RowHeadersWidth = 51;
            marksGrid.RowTemplate.Height = 25;
            marksGrid.Size = new Size(744, 236);
            marksGrid.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 81);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 7;
            label1.Text = "Course:";
            // 
            // courseBoxMarks
            // 
            courseBoxMarks.FormattingEnabled = true;
            courseBoxMarks.Location = new Point(345, 77);
            courseBoxMarks.Margin = new Padding(3, 4, 3, 4);
            courseBoxMarks.Name = "courseBoxMarks";
            courseBoxMarks.Size = new Size(163, 28);
            courseBoxMarks.TabIndex = 6;
            courseBoxMarks.SelectedIndexChanged += courseBoxMarks_SelectedIndexChanged;
            // 
            // viewGrades
            // 
            viewGrades.BackColor = Color.WhiteSmoke;
            viewGrades.Controls.Add(gradeGrid);
            viewGrades.ForeColor = Color.Black;
            viewGrades.Location = new Point(4, 29);
            viewGrades.Margin = new Padding(3, 4, 3, 4);
            viewGrades.Name = "viewGrades";
            viewGrades.Padding = new Padding(11, 13, 11, 13);
            viewGrades.Size = new Size(797, 443);
            viewGrades.TabIndex = 2;
            viewGrades.Text = "View Grades";
            // 
            // gradeGrid
            // 
            gradeGrid.AllowUserToAddRows = false;
            gradeGrid.AllowUserToDeleteRows = false;
            gradeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gradeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradeGrid.Location = new Point(205, 120);
            gradeGrid.Margin = new Padding(3, 4, 3, 4);
            gradeGrid.Name = "gradeGrid";
            gradeGrid.ReadOnly = true;
            gradeGrid.RowHeadersWidth = 51;
            gradeGrid.RowTemplate.Height = 25;
            gradeGrid.Size = new Size(366, 208);
            gradeGrid.TabIndex = 8;
            // 
            // regCourses
            // 
            regCourses.BackColor = Color.WhiteSmoke;
            regCourses.Controls.Add(courseGrid);
            regCourses.Location = new Point(4, 29);
            regCourses.Margin = new Padding(3, 4, 3, 4);
            regCourses.Name = "regCourses";
            regCourses.Padding = new Padding(11, 13, 11, 13);
            regCourses.Size = new Size(797, 443);
            regCourses.TabIndex = 3;
            regCourses.Text = "Registered Courses";
            // 
            // courseGrid
            // 
            courseGrid.AllowUserToAddRows = false;
            courseGrid.AllowUserToDeleteRows = false;
            courseGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            courseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseGrid.Location = new Point(205, 120);
            courseGrid.Margin = new Padding(3, 4, 3, 4);
            courseGrid.Name = "courseGrid";
            courseGrid.ReadOnly = true;
            courseGrid.RowHeadersWidth = 51;
            courseGrid.RowTemplate.Height = 25;
            courseGrid.Size = new Size(366, 208);
            courseGrid.TabIndex = 9;
            // 
            // feeStatus
            // 
            feeStatus.BackColor = Color.WhiteSmoke;
            feeStatus.Controls.Add(paidOrUnpaidLbl);
            feeStatus.Controls.Add(label2);
            feeStatus.Location = new Point(4, 29);
            feeStatus.Margin = new Padding(3, 4, 3, 4);
            feeStatus.Name = "feeStatus";
            feeStatus.Size = new Size(797, 443);
            feeStatus.TabIndex = 4;
            feeStatus.Text = "Fee Status";
            // 
            // paidOrUnpaidLbl
            // 
            paidOrUnpaidLbl.AutoSize = true;
            paidOrUnpaidLbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            paidOrUnpaidLbl.ForeColor = Color.Red;
            paidOrUnpaidLbl.Location = new Point(438, 177);
            paidOrUnpaidLbl.Name = "paidOrUnpaidLbl";
            paidOrUnpaidLbl.Size = new Size(223, 81);
            paidOrUnpaidLbl.TabIndex = 1;
            paidOrUnpaidLbl.Text = "UnPaid";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(130, 177);
            label2.Name = "label2";
            label2.Size = new Size(315, 81);
            label2.TabIndex = 0;
            label2.Text = "Fee Status:";
            // 
            // logoutLBl
            // 
            logoutLBl.AutoSize = true;
            logoutLBl.BackColor = Color.Gray;
            logoutLBl.Cursor = Cursors.Hand;
            logoutLBl.ForeColor = Color.WhiteSmoke;
            logoutLBl.Location = new Point(837, 9);
            logoutLBl.Name = "logoutLBl";
            logoutLBl.Size = new Size(56, 20);
            logoutLBl.TabIndex = 4;
            logoutLBl.Text = "Logout";
            logoutLBl.Click += logoutLBl_Click;
            // 
            // studentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(914, 557);
            Controls.Add(logoutLBl);
            Controls.Add(studentMainTab);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "studentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flex | Student Form";
            Load += studentForm_Load;
            studentMainTab.ResumeLayout(false);
            homePageStd.ResumeLayout(false);
            homePageStd.PerformLayout();
            viewAttendance.ResumeLayout(false);
            viewAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).EndInit();
            viewMarks.ResumeLayout(false);
            viewMarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)marksGrid).EndInit();
            viewGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradeGrid).EndInit();
            regCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)courseGrid).EndInit();
            feeStatus.ResumeLayout(false);
            feeStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl studentMainTab;
        private TabPage viewAttendance;
        private TabPage viewMarks;
        private TabPage viewGrades;
        private string userName;
        private TabPage regCourses;
        private TabPage feeStatus;
        private Label logoutLBl;
        private TabPage homePageStd;
        private TextBox genderBox;
        private TextBox DepStdBox;
        private TextBox bloodBoxStd;
        private Label salaryLbl;
        private TextBox AdressStdBox;
        private Label label3;
        private TextBox QualificationStdBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ContactStdBox;
        private Label label7;
        private TextBox LNameStdBox;
        private Label label8;
        private TextBox FNameStdBox;
        private Label label9;
        private DataGridView attendanceGrid;
        private Label courseLblAtnd;
        private ComboBox courseBoxAtnd;
        private DateTimePicker dateTimePicker1;
        private DataGridView marksGrid;
        private Label label1;
        private ComboBox courseBoxMarks;
        private DataGridView dataGridView1;
        private DataGridView gradeGrid;
        private DataGridView courseGrid;
        private Label label2;
        private Label paidOrUnpaidLbl;
    }
}