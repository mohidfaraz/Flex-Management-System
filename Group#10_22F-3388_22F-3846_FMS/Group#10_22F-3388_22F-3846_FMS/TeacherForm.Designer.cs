using System.Windows.Forms;

namespace Group_10_22F_3388_22F_3846_FMS
{
    partial class teacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherForm));
            tabcontrol1 = new TabControl();
            tabPage1 = new TabPage();
            genderTxt = new TextBox();
            DepTeacherTxt = new TextBox();
            salaryTxt = new TextBox();
            salaryLbl = new Label();
            AdressTeacherTxt = new TextBox();
            label3 = new Label();
            QualificationTeacherTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ContactTeacherTxt = new TextBox();
            label7 = new Label();
            lastNameTeacherTxt = new TextBox();
            label8 = new Label();
            FNameTeacherTxt = new TextBox();
            label9 = new Label();
            timetableTab1 = new TabPage();
            timetableGrid = new DataGridView();
            updateMarks = new TabPage();
            updateMarksGrid = new DataGridView();
            updateBtnEdit = new Button();
            lastNameBoxTchMarks = new TextBox();
            lastNameEditLbl = new Label();
            firstNameBoxTchMarks = new TextBox();
            fNameLblEdit = new Label();
            enterBtnEdit = new Button();
            rollBoxTchMarks = new TextBox();
            rollNoLblInEdit = new Label();
            assignGrade = new TabPage();
            label10 = new Label();
            gradeGrid = new DataGridView();
            updateGradeBtn = new Button();
            lNameGrade = new TextBox();
            rollNoGrade = new TextBox();
            label1 = new Label();
            enterBtnGrades = new Button();
            fNameGrade = new TextBox();
            label2 = new Label();
            attendanceTab = new TabPage();
            rollNoLblAttendance = new Label();
            dateTimePicker1 = new DateTimePicker();
            attendanceGrid = new DataGridView();
            updateAttendanceBtn = new Button();
            rollNoBoxAttendance = new TextBox();
            enterAttendanceBTn = new Button();
            logoutLBl = new Label();
            tabcontrol1.SuspendLayout();
            tabPage1.SuspendLayout();
            timetableTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timetableGrid).BeginInit();
            updateMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updateMarksGrid).BeginInit();
            assignGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradeGrid).BeginInit();
            attendanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // tabcontrol1
            // 
            tabcontrol1.Controls.Add(tabPage1);
            tabcontrol1.Controls.Add(timetableTab1);
            tabcontrol1.Controls.Add(updateMarks);
            tabcontrol1.Controls.Add(assignGrade);
            tabcontrol1.Controls.Add(attendanceTab);
            tabcontrol1.Location = new Point(12, 33);
            tabcontrol1.Margin = new Padding(3, 4, 3, 4);
            tabcontrol1.Name = "tabcontrol1";
            tabcontrol1.SelectedIndex = 0;
            tabcontrol1.Size = new Size(881, 644);
            tabcontrol1.TabIndex = 0;
            tabcontrol1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(genderTxt);
            tabPage1.Controls.Add(DepTeacherTxt);
            tabPage1.Controls.Add(salaryTxt);
            tabPage1.Controls.Add(salaryLbl);
            tabPage1.Controls.Add(AdressTeacherTxt);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(QualificationTeacherTxt);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(ContactTeacherTxt);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(lastNameTeacherTxt);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(FNameTeacherTxt);
            tabPage1.Controls.Add(label9);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(873, 611);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // genderTxt
            // 
            genderTxt.BackColor = SystemColors.Window;
            genderTxt.BorderStyle = BorderStyle.None;
            genderTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            genderTxt.Location = new Point(581, 293);
            genderTxt.Margin = new Padding(3, 4, 3, 4);
            genderTxt.Name = "genderTxt";
            genderTxt.ReadOnly = true;
            genderTxt.Size = new Size(151, 22);
            genderTxt.TabIndex = 81;
            // 
            // DepTeacherTxt
            // 
            DepTeacherTxt.BackColor = SystemColors.Window;
            DepTeacherTxt.BorderStyle = BorderStyle.None;
            DepTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DepTeacherTxt.Location = new Point(581, 178);
            DepTeacherTxt.Margin = new Padding(3, 4, 3, 4);
            DepTeacherTxt.Name = "DepTeacherTxt";
            DepTeacherTxt.ReadOnly = true;
            DepTeacherTxt.Size = new Size(151, 22);
            DepTeacherTxt.TabIndex = 80;
            // 
            // salaryTxt
            // 
            salaryTxt.BackColor = SystemColors.Window;
            salaryTxt.BorderStyle = BorderStyle.None;
            salaryTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salaryTxt.Location = new Point(581, 236);
            salaryTxt.Margin = new Padding(3, 4, 3, 4);
            salaryTxt.Name = "salaryTxt";
            salaryTxt.ReadOnly = true;
            salaryTxt.Size = new Size(151, 22);
            salaryTxt.TabIndex = 79;
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            salaryLbl.Location = new Point(507, 234);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(65, 23);
            salaryLbl.TabIndex = 77;
            salaryLbl.Text = "Salary:";
            // 
            // AdressTeacherTxt
            // 
            AdressTeacherTxt.BackColor = SystemColors.Window;
            AdressTeacherTxt.BorderStyle = BorderStyle.None;
            AdressTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AdressTeacherTxt.Location = new Point(206, 292);
            AdressTeacherTxt.Margin = new Padding(3, 4, 3, 4);
            AdressTeacherTxt.Multiline = true;
            AdressTeacherTxt.Name = "AdressTeacherTxt";
            AdressTeacherTxt.ReadOnly = true;
            AdressTeacherTxt.Size = new Size(151, 59);
            AdressTeacherTxt.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(92, 292);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 75;
            label3.Text = "Address:";
            // 
            // QualificationTeacherTxt
            // 
            QualificationTeacherTxt.BackColor = SystemColors.Window;
            QualificationTeacherTxt.BorderStyle = BorderStyle.None;
            QualificationTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            QualificationTeacherTxt.Location = new Point(206, 231);
            QualificationTeacherTxt.Margin = new Padding(3, 4, 3, 4);
            QualificationTeacherTxt.Name = "QualificationTeacherTxt";
            QualificationTeacherTxt.ReadOnly = true;
            QualificationTeacherTxt.Size = new Size(151, 22);
            QualificationTeacherTxt.TabIndex = 74;
            QualificationTeacherTxt.TextChanged += QualificationTeacherTxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(82, 230);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 73;
            label4.Text = "Qualification:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(499, 292);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 72;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(469, 178);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 71;
            label6.Text = "Department:";
            // 
            // ContactTeacherTxt
            // 
            ContactTeacherTxt.BackColor = SystemColors.Window;
            ContactTeacherTxt.BorderStyle = BorderStyle.None;
            ContactTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ContactTeacherTxt.Location = new Point(206, 178);
            ContactTeacherTxt.Margin = new Padding(3, 4, 3, 4);
            ContactTeacherTxt.Name = "ContactTeacherTxt";
            ContactTeacherTxt.ReadOnly = true;
            ContactTeacherTxt.Size = new Size(151, 22);
            ContactTeacherTxt.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(82, 178);
            label7.Name = "label7";
            label7.Size = new Size(105, 23);
            label7.TabIndex = 69;
            label7.Text = "Contact No:";
            // 
            // lastNameTeacherTxt
            // 
            lastNameTeacherTxt.BackColor = SystemColors.Window;
            lastNameTeacherTxt.BorderStyle = BorderStyle.None;
            lastNameTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTeacherTxt.Location = new Point(581, 130);
            lastNameTeacherTxt.Margin = new Padding(3, 4, 3, 4);
            lastNameTeacherTxt.Name = "lastNameTeacherTxt";
            lastNameTeacherTxt.ReadOnly = true;
            lastNameTeacherTxt.Size = new Size(151, 22);
            lastNameTeacherTxt.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(476, 129);
            label8.Name = "label8";
            label8.Size = new Size(99, 23);
            label8.TabIndex = 67;
            label8.Text = "Last Name:";
            // 
            // FNameTeacherTxt
            // 
            FNameTeacherTxt.BackColor = SystemColors.Window;
            FNameTeacherTxt.BorderStyle = BorderStyle.None;
            FNameTeacherTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FNameTeacherTxt.Location = new Point(206, 125);
            FNameTeacherTxt.Margin = new Padding(3, 4, 3, 4);
            FNameTeacherTxt.Name = "FNameTeacherTxt";
            FNameTeacherTxt.ReadOnly = true;
            FNameTeacherTxt.Size = new Size(151, 22);
            FNameTeacherTxt.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(82, 125);
            label9.Name = "label9";
            label9.Size = new Size(102, 23);
            label9.TabIndex = 64;
            label9.Text = "First Name:";
            // 
            // timetableTab1
            // 
            timetableTab1.Controls.Add(timetableGrid);
            timetableTab1.Location = new Point(4, 29);
            timetableTab1.Margin = new Padding(3, 4, 3, 4);
            timetableTab1.Name = "timetableTab1";
            timetableTab1.Padding = new Padding(3, 4, 3, 4);
            timetableTab1.Size = new Size(873, 611);
            timetableTab1.TabIndex = 0;
            timetableTab1.Text = "View Timetable";
            timetableTab1.UseVisualStyleBackColor = true;
            // 
            // timetableGrid
            // 
            timetableGrid.AllowUserToAddRows = false;
            timetableGrid.AllowUserToDeleteRows = false;
            timetableGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            timetableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timetableGrid.Location = new Point(40, 118);
            timetableGrid.Margin = new Padding(3, 4, 3, 4);
            timetableGrid.Name = "timetableGrid";
            timetableGrid.ReadOnly = true;
            timetableGrid.RowHeadersWidth = 51;
            timetableGrid.RowTemplate.Height = 25;
            timetableGrid.Size = new Size(775, 360);
            timetableGrid.TabIndex = 0;
            // 
            // updateMarks
            // 
            updateMarks.Controls.Add(updateMarksGrid);
            updateMarks.Controls.Add(updateBtnEdit);
            updateMarks.Controls.Add(lastNameBoxTchMarks);
            updateMarks.Controls.Add(lastNameEditLbl);
            updateMarks.Controls.Add(firstNameBoxTchMarks);
            updateMarks.Controls.Add(fNameLblEdit);
            updateMarks.Controls.Add(enterBtnEdit);
            updateMarks.Controls.Add(rollBoxTchMarks);
            updateMarks.Controls.Add(rollNoLblInEdit);
            updateMarks.Location = new Point(4, 29);
            updateMarks.Margin = new Padding(3, 4, 3, 4);
            updateMarks.Name = "updateMarks";
            updateMarks.Padding = new Padding(3, 4, 3, 4);
            updateMarks.Size = new Size(873, 611);
            updateMarks.TabIndex = 1;
            updateMarks.Text = "Update Marks";
            updateMarks.UseVisualStyleBackColor = true;
            // 
            // updateMarksGrid
            // 
            updateMarksGrid.AllowUserToAddRows = false;
            updateMarksGrid.AllowUserToDeleteRows = false;
            updateMarksGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            updateMarksGrid.Location = new Point(53, 180);
            updateMarksGrid.Margin = new Padding(3, 4, 3, 4);
            updateMarksGrid.Name = "updateMarksGrid";
            updateMarksGrid.RowHeadersWidth = 51;
            updateMarksGrid.RowTemplate.Height = 25;
            updateMarksGrid.Size = new Size(766, 247);
            updateMarksGrid.TabIndex = 30;
            updateMarksGrid.CellValueChanged += updateMarksGrid_CellValueChanged;
            // 
            // updateBtnEdit
            // 
            updateBtnEdit.Location = new Point(314, 435);
            updateBtnEdit.Margin = new Padding(3, 4, 3, 4);
            updateBtnEdit.Name = "updateBtnEdit";
            updateBtnEdit.Size = new Size(232, 43);
            updateBtnEdit.TabIndex = 29;
            updateBtnEdit.Text = "Update";
            updateBtnEdit.UseVisualStyleBackColor = true;
            updateBtnEdit.Click += updateBtnEdit_Click;
            // 
            // lastNameBoxTchMarks
            // 
            lastNameBoxTchMarks.Location = new Point(513, 113);
            lastNameBoxTchMarks.Margin = new Padding(3, 4, 3, 4);
            lastNameBoxTchMarks.Name = "lastNameBoxTchMarks";
            lastNameBoxTchMarks.ReadOnly = true;
            lastNameBoxTchMarks.Size = new Size(158, 27);
            lastNameBoxTchMarks.TabIndex = 21;
            // 
            // lastNameEditLbl
            // 
            lastNameEditLbl.AutoSize = true;
            lastNameEditLbl.Location = new Point(429, 117);
            lastNameEditLbl.Name = "lastNameEditLbl";
            lastNameEditLbl.Size = new Size(82, 20);
            lastNameEditLbl.TabIndex = 20;
            lastNameEditLbl.Text = "Last Name:";
            // 
            // firstNameBoxTchMarks
            // 
            firstNameBoxTchMarks.Location = new Point(513, 57);
            firstNameBoxTchMarks.Margin = new Padding(3, 4, 3, 4);
            firstNameBoxTchMarks.Name = "firstNameBoxTchMarks";
            firstNameBoxTchMarks.ReadOnly = true;
            firstNameBoxTchMarks.Size = new Size(158, 27);
            firstNameBoxTchMarks.TabIndex = 19;
            // 
            // fNameLblEdit
            // 
            fNameLblEdit.AutoSize = true;
            fNameLblEdit.Location = new Point(429, 61);
            fNameLblEdit.Name = "fNameLblEdit";
            fNameLblEdit.Size = new Size(83, 20);
            fNameLblEdit.TabIndex = 18;
            fNameLblEdit.Text = "First Name:";
            // 
            // enterBtnEdit
            // 
            enterBtnEdit.Location = new Point(201, 108);
            enterBtnEdit.Margin = new Padding(3, 4, 3, 4);
            enterBtnEdit.Name = "enterBtnEdit";
            enterBtnEdit.Size = new Size(138, 37);
            enterBtnEdit.TabIndex = 17;
            enterBtnEdit.Text = "Enter";
            enterBtnEdit.UseVisualStyleBackColor = true;
            enterBtnEdit.Click += enterBtnEdit_Click;
            // 
            // rollBoxTchMarks
            // 
            rollBoxTchMarks.Location = new Point(201, 51);
            rollBoxTchMarks.Margin = new Padding(3, 4, 3, 4);
            rollBoxTchMarks.Multiline = true;
            rollBoxTchMarks.Name = "rollBoxTchMarks";
            rollBoxTchMarks.Size = new Size(156, 35);
            rollBoxTchMarks.TabIndex = 16;
            // 
            // rollNoLblInEdit
            // 
            rollNoLblInEdit.AutoSize = true;
            rollNoLblInEdit.Location = new Point(138, 55);
            rollNoLblInEdit.Name = "rollNoLblInEdit";
            rollNoLblInEdit.Size = new Size(62, 20);
            rollNoLblInEdit.TabIndex = 15;
            rollNoLblInEdit.Text = "Roll No:";
            // 
            // assignGrade
            // 
            assignGrade.Controls.Add(label10);
            assignGrade.Controls.Add(gradeGrid);
            assignGrade.Controls.Add(updateGradeBtn);
            assignGrade.Controls.Add(lNameGrade);
            assignGrade.Controls.Add(rollNoGrade);
            assignGrade.Controls.Add(label1);
            assignGrade.Controls.Add(enterBtnGrades);
            assignGrade.Controls.Add(fNameGrade);
            assignGrade.Controls.Add(label2);
            assignGrade.Location = new Point(4, 29);
            assignGrade.Margin = new Padding(3, 4, 3, 4);
            assignGrade.Name = "assignGrade";
            assignGrade.Size = new Size(873, 611);
            assignGrade.TabIndex = 2;
            assignGrade.Text = "Assign Grade";
            assignGrade.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(153, 51);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 16;
            label10.Text = "Roll No:";
            // 
            // gradeGrid
            // 
            gradeGrid.AllowUserToAddRows = false;
            gradeGrid.AllowUserToDeleteRows = false;
            gradeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gradeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradeGrid.Location = new Point(53, 175);
            gradeGrid.Margin = new Padding(3, 4, 3, 4);
            gradeGrid.Name = "gradeGrid";
            gradeGrid.RowHeadersWidth = 51;
            gradeGrid.RowTemplate.Height = 25;
            gradeGrid.Size = new Size(766, 247);
            gradeGrid.TabIndex = 39;
            // 
            // updateGradeBtn
            // 
            updateGradeBtn.Location = new Point(314, 430);
            updateGradeBtn.Margin = new Padding(3, 4, 3, 4);
            updateGradeBtn.Name = "updateGradeBtn";
            updateGradeBtn.Size = new Size(232, 48);
            updateGradeBtn.TabIndex = 38;
            updateGradeBtn.Text = "Update";
            updateGradeBtn.UseVisualStyleBackColor = true;
            updateGradeBtn.Click += updateGradeBtn_Click;
            // 
            // lNameGrade
            // 
            lNameGrade.Location = new Point(528, 103);
            lNameGrade.Margin = new Padding(3, 4, 3, 4);
            lNameGrade.Name = "lNameGrade";
            lNameGrade.ReadOnly = true;
            lNameGrade.Size = new Size(158, 27);
            lNameGrade.TabIndex = 37;
            // 
            // rollNoGrade
            // 
            rollNoGrade.Location = new Point(216, 42);
            rollNoGrade.Margin = new Padding(3, 4, 3, 4);
            rollNoGrade.Multiline = true;
            rollNoGrade.Name = "rollNoGrade";
            rollNoGrade.Size = new Size(156, 35);
            rollNoGrade.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 107);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 36;
            label1.Text = "Last Name:";
            // 
            // enterBtnGrades
            // 
            enterBtnGrades.Location = new Point(216, 99);
            enterBtnGrades.Margin = new Padding(3, 4, 3, 4);
            enterBtnGrades.Name = "enterBtnGrades";
            enterBtnGrades.Size = new Size(138, 37);
            enterBtnGrades.TabIndex = 33;
            enterBtnGrades.Text = "Enter";
            enterBtnGrades.UseVisualStyleBackColor = true;
            enterBtnGrades.Click += enterBtnGrades_Click;
            // 
            // fNameGrade
            // 
            fNameGrade.Location = new Point(528, 47);
            fNameGrade.Margin = new Padding(3, 4, 3, 4);
            fNameGrade.Name = "fNameGrade";
            fNameGrade.ReadOnly = true;
            fNameGrade.Size = new Size(158, 27);
            fNameGrade.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 51);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 34;
            label2.Text = "First Name:";
            // 
            // attendanceTab
            // 
            attendanceTab.Controls.Add(rollNoLblAttendance);
            attendanceTab.Controls.Add(dateTimePicker1);
            attendanceTab.Controls.Add(attendanceGrid);
            attendanceTab.Controls.Add(updateAttendanceBtn);
            attendanceTab.Controls.Add(rollNoBoxAttendance);
            attendanceTab.Controls.Add(enterAttendanceBTn);
            attendanceTab.Location = new Point(4, 29);
            attendanceTab.Margin = new Padding(3, 4, 3, 4);
            attendanceTab.Name = "attendanceTab";
            attendanceTab.Size = new Size(873, 611);
            attendanceTab.TabIndex = 3;
            attendanceTab.Text = "Mark Attendance";
            attendanceTab.UseVisualStyleBackColor = true;
            // 
            // rollNoLblAttendance
            // 
            rollNoLblAttendance.AutoSize = true;
            rollNoLblAttendance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rollNoLblAttendance.Location = new Point(266, 42);
            rollNoLblAttendance.Name = "rollNoLblAttendance";
            rollNoLblAttendance.Size = new Size(74, 23);
            rollNoLblAttendance.TabIndex = 49;
            rollNoLblAttendance.Text = "Roll No:";
            rollNoLblAttendance.Click += rollNoLblAttendance_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(312, 141);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.MinDate = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 27);
            dateTimePicker1.TabIndex = 48;
            // 
            // attendanceGrid
            // 
            attendanceGrid.AllowUserToAddRows = false;
            attendanceGrid.AllowUserToDeleteRows = false;
            attendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendanceGrid.Location = new Point(57, 176);
            attendanceGrid.Margin = new Padding(3, 4, 3, 4);
            attendanceGrid.Name = "attendanceGrid";
            attendanceGrid.RowHeadersWidth = 51;
            attendanceGrid.RowTemplate.Height = 25;
            attendanceGrid.Size = new Size(766, 247);
            attendanceGrid.TabIndex = 47;
            // 
            // updateAttendanceBtn
            // 
            updateAttendanceBtn.Location = new Point(327, 431);
            updateAttendanceBtn.Margin = new Padding(3, 4, 3, 4);
            updateAttendanceBtn.Name = "updateAttendanceBtn";
            updateAttendanceBtn.Size = new Size(232, 47);
            updateAttendanceBtn.TabIndex = 46;
            updateAttendanceBtn.Text = "Update";
            updateAttendanceBtn.UseVisualStyleBackColor = true;
            updateAttendanceBtn.Click += updateAttendanceBtn_Click;
            // 
            // rollNoBoxAttendance
            // 
            rollNoBoxAttendance.Location = new Point(346, 40);
            rollNoBoxAttendance.Margin = new Padding(3, 4, 3, 4);
            rollNoBoxAttendance.Multiline = true;
            rollNoBoxAttendance.Name = "rollNoBoxAttendance";
            rollNoBoxAttendance.Size = new Size(171, 35);
            rollNoBoxAttendance.TabIndex = 40;
            // 
            // enterAttendanceBTn
            // 
            enterAttendanceBTn.Location = new Point(360, 83);
            enterAttendanceBTn.Margin = new Padding(3, 4, 3, 4);
            enterAttendanceBTn.Name = "enterAttendanceBTn";
            enterAttendanceBTn.Size = new Size(138, 37);
            enterAttendanceBTn.TabIndex = 41;
            enterAttendanceBTn.Text = "Enter";
            enterAttendanceBTn.UseVisualStyleBackColor = true;
            enterAttendanceBTn.Click += enterAttendanceBTn_Click;
            // 
            // logoutLBl
            // 
            logoutLBl.AutoSize = true;
            logoutLBl.BackColor = SystemColors.ActiveBorder;
            logoutLBl.Cursor = Cursors.Hand;
            logoutLBl.ForeColor = Color.Black;
            logoutLBl.Location = new Point(814, 9);
            logoutLBl.Name = "logoutLBl";
            logoutLBl.Size = new Size(56, 20);
            logoutLBl.TabIndex = 2;
            logoutLBl.Text = "Logout";
            logoutLBl.Click += logoutLBl_Click;
            // 
            // teacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(882, 553);
            Controls.Add(logoutLBl);
            Controls.Add(tabcontrol1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "teacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flex | Teacher Form";
            Load += teacherForm_Load;
            tabcontrol1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            timetableTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timetableGrid).EndInit();
            updateMarks.ResumeLayout(false);
            updateMarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updateMarksGrid).EndInit();
            assignGrade.ResumeLayout(false);
            assignGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradeGrid).EndInit();
            attendanceTab.ResumeLayout(false);
            attendanceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabcontrol1;
        private TabPage timetableTab1;
        private TabPage updateMarks;
        private Button updateBtnEdit;
        private TextBox lastNameBoxTchMarks;
        private Label lastNameEditLbl;
        private TextBox firstNameBoxTchMarks;
        private Label fNameLblEdit;
        private Button enterBtnEdit;
        private TextBox rollBoxTchMarks;
        private Label rollNoLblInEdit;
        private DataGridView updateMarksGrid;
        private TabPage assignGrade;
        private DataGridView gradeGrid;
        private Button updateGradeBtn;
        private Label label3;
        private TextBox lNameGrade;
        private TextBox rollNoGrade;
        private Label label1;
        private Button enterBtnGrades;
        private TextBox fNameGrade;
        private Label label2;
        private DataGridView timetableGrid;
        private TextBox salaryTxt;
        private Label salaryLbl;
        private TextBox AdressTeacherTxt;
        // private Label label3;
        private TextBox QualificationTeacherTxt;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ContactTeacherTxt;
        private Label label7;
        private TextBox lastNameTeacherTxt;
        private Label label8;
        private TextBox FNameTeacherTxt;
        private Label label9;
        private TextBox DepTeacherTxt;
        private TextBox genderTxt;
        private TabPage tabPage1;
        private TabPage attendanceTab;
        private DataGridView attendanceGrid;
        private Button updateAttendanceBtn;
        private TextBox rollNoBoxAttendance;
        private Button enterAttendanceBTn;
        private DateTimePicker dateTimePicker1;
        private Label rollNoLblAttendance;
        private Label logoutLBl;
        private Label label10;
    }
}