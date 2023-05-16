using System.Windows.Forms;
using System.Xml.Linq;
using static adminFile.admin;
using static System.Net.Mime.MediaTypeNames;

namespace Group_10_22F_3388_22F_3846_FMS
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            adminTAB = new TabControl();
            addStudent = new TabPage();
            courseLbl = new Label();
            courseBox = new CheckedListBox();
            UnpaidBtn = new RadioButton();
            paidButton = new RadioButton();
            feeStatLbl = new Label();
            bloodGroupBox = new ComboBox();
            bloodLbl = new Label();
            addressLbl = new Label();
            addressBox = new TextBox();
            deptBox = new ComboBox();
            deptLbl = new Label();
            QualificationBox = new ComboBox();
            qualificationLbl = new Label();
            genderBox = new ComboBox();
            genderLbl = new Label();
            contactBox = new TextBox();
            contactLbl = new Label();
            addStudentBtn = new Button();
            lastNameLbl = new Label();
            lastNameBox = new TextBox();
            firstNameBox = new TextBox();
            firstNameLbl = new Label();
            addTeacher = new TabPage();
            courseTchLbl = new Label();
            courseBoxTch = new ComboBox();
            addBtnTch = new Button();
            salaryLblTch = new Label();
            salaryBoxTch = new TextBox();
            qualficationLblTch = new Label();
            deptLblTch = new Label();
            qualificationBoxTch = new ComboBox();
            deptBoxTch = new ComboBox();
            genderBoxTch = new ComboBox();
            genderLblTch = new Label();
            addressLblTch = new Label();
            label3 = new Label();
            LNameLblTch = new Label();
            addressBoxTch = new TextBox();
            contactBoxTch = new TextBox();
            LNameBoxTch = new TextBox();
            fNameBoxTch = new TextBox();
            fNameLblTch = new Label();
            editStdTab = new TabPage();
            updateBtnEdit = new Button();
            feeLblEdit = new Label();
            unPaidEdit = new RadioButton();
            paidBtnEdit = new RadioButton();
            addressLblInEdit = new Label();
            contactLblInEdit = new Label();
            addressBoxEdit = new TextBox();
            contactBoxEdit = new TextBox();
            lastNameBoxEdit = new TextBox();
            lastNameEditLbl = new Label();
            firstNameBoxEdit = new TextBox();
            fNameLblEdit = new Label();
            enterBtnEdit = new Button();
            rollBoxEdit = new TextBox();
            rollNoLblInEdit = new Label();
            editTeacher = new TabPage();
            qualificationBoxTchEdit = new ComboBox();
            QualificationLblTchEdit = new Label();
            updateBtnTchEdit = new Button();
            tidBoxEdit = new TextBox();
            tIdLbl = new Label();
            enterBtnEditTch = new Button();
            label4 = new Label();
            label5 = new Label();
            salaryLblEdit = new Label();
            addressBoxEditTch = new TextBox();
            salaryBoxEdit = new TextBox();
            contactBoxEditTch = new TextBox();
            viewStudents = new TabPage();
            showBtn = new Button();
            viewByRollPnl = new Panel();
            rollNoInViewBox = new TextBox();
            rollNoLblInView = new Label();
            label1 = new Label();
            viewByDept = new Panel();
            deptInViewBox = new ComboBox();
            viewStdBox = new ComboBox();
            studentGrid = new DataGridView();
            viewTeachers = new TabPage();
            teacherGrid = new DataGridView();
            logoutLBl = new Label();
            adminTAB.SuspendLayout();
            addStudent.SuspendLayout();
            addTeacher.SuspendLayout();
            editStdTab.SuspendLayout();
            editTeacher.SuspendLayout();
            viewStudents.SuspendLayout();
            viewByRollPnl.SuspendLayout();
            viewByDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            viewTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacherGrid).BeginInit();
            SuspendLayout();
            // 
            // adminTAB
            // 
            adminTAB.Controls.Add(addStudent);
            adminTAB.Controls.Add(addTeacher);
            adminTAB.Controls.Add(editStdTab);
            adminTAB.Controls.Add(editTeacher);
            adminTAB.Controls.Add(viewStudents);
            adminTAB.Controls.Add(viewTeachers);
            adminTAB.Location = new Point(46, 24);
            adminTAB.Margin = new Padding(3, 4, 3, 4);
            adminTAB.Name = "adminTAB";
            adminTAB.SelectedIndex = 0;
            adminTAB.Size = new Size(805, 472);
            adminTAB.TabIndex = 2;
            adminTAB.Click += adminTAB_Click;
            // 
            // addStudent
            // 
            addStudent.BackColor = Color.WhiteSmoke;
            addStudent.Controls.Add(courseLbl);
            addStudent.Controls.Add(courseBox);
            addStudent.Controls.Add(UnpaidBtn);
            addStudent.Controls.Add(paidButton);
            addStudent.Controls.Add(feeStatLbl);
            addStudent.Controls.Add(bloodGroupBox);
            addStudent.Controls.Add(bloodLbl);
            addStudent.Controls.Add(addressLbl);
            addStudent.Controls.Add(addressBox);
            addStudent.Controls.Add(deptBox);
            addStudent.Controls.Add(deptLbl);
            addStudent.Controls.Add(QualificationBox);
            addStudent.Controls.Add(qualificationLbl);
            addStudent.Controls.Add(genderBox);
            addStudent.Controls.Add(genderLbl);
            addStudent.Controls.Add(contactBox);
            addStudent.Controls.Add(contactLbl);
            addStudent.Controls.Add(addStudentBtn);
            addStudent.Controls.Add(lastNameLbl);
            addStudent.Controls.Add(lastNameBox);
            addStudent.Controls.Add(firstNameBox);
            addStudent.Controls.Add(firstNameLbl);
            addStudent.Location = new Point(4, 29);
            addStudent.Margin = new Padding(3, 4, 3, 4);
            addStudent.Name = "addStudent";
            addStudent.Padding = new Padding(11, 13, 11, 13);
            addStudent.Size = new Size(797, 439);
            addStudent.TabIndex = 0;
            addStudent.Text = "Add Student";
            // 
            // courseLbl
            // 
            courseLbl.AutoSize = true;
            courseLbl.ForeColor = Color.Black;
            courseLbl.Location = new Point(662, 104);
            courseLbl.Name = "courseLbl";
            courseLbl.Size = new Size(63, 20);
            courseLbl.TabIndex = 24;
            courseLbl.Text = "Courses:";
            // 
            // courseBox
            // 
            courseBox.FormattingEnabled = true;
            courseBox.Items.AddRange(new object[] { "DLD", "PF", "LA", "CAL", "ENG", "PS", "IS" });
            courseBox.Location = new Point(632, 139);
            courseBox.Margin = new Padding(3, 4, 3, 4);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(138, 114);
            courseBox.TabIndex = 3;
            // 
            // UnpaidBtn
            // 
            UnpaidBtn.AutoSize = true;
            UnpaidBtn.ForeColor = Color.Black;
            UnpaidBtn.Location = new Point(542, 307);
            UnpaidBtn.Margin = new Padding(3, 4, 3, 4);
            UnpaidBtn.Name = "UnpaidBtn";
            UnpaidBtn.Size = new Size(78, 24);
            UnpaidBtn.TabIndex = 23;
            UnpaidBtn.TabStop = true;
            UnpaidBtn.Text = "Unpaid";
            UnpaidBtn.UseVisualStyleBackColor = true;
            // 
            // paidButton
            // 
            paidButton.AutoSize = true;
            paidButton.ForeColor = Color.Black;
            paidButton.Location = new Point(475, 307);
            paidButton.Margin = new Padding(3, 4, 3, 4);
            paidButton.Name = "paidButton";
            paidButton.Size = new Size(58, 24);
            paidButton.TabIndex = 22;
            paidButton.TabStop = true;
            paidButton.Text = "Paid";
            paidButton.UseVisualStyleBackColor = true;
            // 
            // feeStatLbl
            // 
            feeStatLbl.AutoSize = true;
            feeStatLbl.ForeColor = Color.Black;
            feeStatLbl.Location = new Point(366, 307);
            feeStatLbl.Name = "feeStatLbl";
            feeStatLbl.Size = new Size(76, 20);
            feeStatLbl.TabIndex = 21;
            feeStatLbl.Text = "Fee Status";
            // 
            // bloodGroupBox
            // 
            bloodGroupBox.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            bloodGroupBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodGroupBox.FormattingEnabled = true;
            bloodGroupBox.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            bloodGroupBox.Location = new Point(475, 243);
            bloodGroupBox.Margin = new Padding(3, 4, 3, 4);
            bloodGroupBox.Name = "bloodGroupBox";
            bloodGroupBox.Size = new Size(138, 28);
            bloodGroupBox.TabIndex = 20;
            // 
            // bloodLbl
            // 
            bloodLbl.AutoSize = true;
            bloodLbl.ForeColor = Color.Black;
            bloodLbl.Location = new Point(366, 247);
            bloodLbl.Name = "bloodLbl";
            bloodLbl.Size = new Size(97, 20);
            bloodLbl.TabIndex = 19;
            bloodLbl.Text = "Blood Group:";
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.ForeColor = Color.Black;
            addressLbl.Location = new Point(41, 251);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(69, 20);
            addressLbl.TabIndex = 18;
            addressLbl.Text = " Address:";
            // 
            // addressBox
            // 
            addressBox.Location = new Point(135, 247);
            addressBox.Margin = new Padding(3, 4, 3, 4);
            addressBox.Multiline = true;
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(158, 75);
            addressBox.TabIndex = 17;
            // 
            // deptBox
            // 
            deptBox.AutoCompleteCustomSource.AddRange(new string[] { "Computer", "Software", "Electrical", "Social Sciences", "BBA" });
            deptBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deptBox.FormattingEnabled = true;
            deptBox.Items.AddRange(new object[] { "Computer", "Software", "Electrical", "Social Sciences", "BBA" });
            deptBox.Location = new Point(475, 187);
            deptBox.Margin = new Padding(3, 4, 3, 4);
            deptBox.Name = "deptBox";
            deptBox.Size = new Size(138, 28);
            deptBox.TabIndex = 16;
            // 
            // deptLbl
            // 
            deptLbl.AutoSize = true;
            deptLbl.ForeColor = Color.Black;
            deptLbl.Location = new Point(366, 193);
            deptLbl.Name = "deptLbl";
            deptLbl.Size = new Size(92, 20);
            deptLbl.TabIndex = 15;
            deptLbl.Text = "Department:";
            // 
            // QualificationBox
            // 
            QualificationBox.DropDownStyle = ComboBoxStyle.DropDownList;
            QualificationBox.FormattingEnabled = true;
            QualificationBox.Items.AddRange(new object[] { "Intermediate", "A-levels" });
            QualificationBox.Location = new Point(475, 139);
            QualificationBox.Margin = new Padding(3, 4, 3, 4);
            QualificationBox.Name = "QualificationBox";
            QualificationBox.Size = new Size(138, 28);
            QualificationBox.TabIndex = 14;
            // 
            // qualificationLbl
            // 
            qualificationLbl.AutoSize = true;
            qualificationLbl.ForeColor = Color.Black;
            qualificationLbl.Location = new Point(366, 143);
            qualificationLbl.Name = "qualificationLbl";
            qualificationLbl.Size = new Size(97, 20);
            qualificationLbl.TabIndex = 13;
            qualificationLbl.Text = "Qualification:";
            // 
            // genderBox
            // 
            genderBox.AutoCompleteCustomSource.AddRange(new string[] { "Male", "Female", "Other", "Rather not say", "car" });
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(475, 89);
            genderBox.Margin = new Padding(3, 4, 3, 4);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(138, 28);
            genderBox.TabIndex = 12;
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.ForeColor = Color.Black;
            genderLbl.Location = new Point(366, 93);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(60, 20);
            genderLbl.TabIndex = 11;
            genderLbl.Text = "Gender:";
            genderLbl.Click += genderLbl_Click;
            // 
            // contactBox
            // 
            contactBox.Location = new Point(135, 193);
            contactBox.Margin = new Padding(3, 4, 3, 4);
            contactBox.Name = "contactBox";
            contactBox.Size = new Size(158, 27);
            contactBox.TabIndex = 6;
            // 
            // contactLbl
            // 
            contactLbl.AutoSize = true;
            contactLbl.ForeColor = Color.Black;
            contactLbl.Location = new Point(41, 197);
            contactLbl.Name = "contactLbl";
            contactLbl.Size = new Size(87, 20);
            contactLbl.TabIndex = 5;
            contactLbl.Text = "Contact No:";
            // 
            // addStudentBtn
            // 
            addStudentBtn.ForeColor = Color.Black;
            addStudentBtn.Location = new Point(271, 385);
            addStudentBtn.Margin = new Padding(3, 4, 3, 4);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(216, 52);
            addStudentBtn.TabIndex = 4;
            addStudentBtn.Text = "Add";
            addStudentBtn.UseVisualStyleBackColor = true;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.ForeColor = Color.Black;
            lastNameLbl.Location = new Point(41, 143);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(82, 20);
            lastNameLbl.TabIndex = 3;
            lastNameLbl.Text = "Last Name:";
            // 
            // lastNameBox
            // 
            lastNameBox.AutoCompleteCustomSource.AddRange(new string[] { "rashid" });
            lastNameBox.Location = new Point(135, 139);
            lastNameBox.Margin = new Padding(3, 4, 3, 4);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(158, 27);
            lastNameBox.TabIndex = 2;
            // 
            // firstNameBox
            // 
            firstNameBox.AutoCompleteCustomSource.AddRange(new string[] { "hassan" });
            firstNameBox.Location = new Point(135, 85);
            firstNameBox.Margin = new Padding(3, 4, 3, 4);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(158, 27);
            firstNameBox.TabIndex = 1;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.ForeColor = Color.Black;
            firstNameLbl.Location = new Point(41, 89);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(83, 20);
            firstNameLbl.TabIndex = 0;
            firstNameLbl.Text = "First Name:";
            // 
            // addTeacher
            // 
            addTeacher.BackColor = Color.WhiteSmoke;
            addTeacher.Controls.Add(courseTchLbl);
            addTeacher.Controls.Add(courseBoxTch);
            addTeacher.Controls.Add(addBtnTch);
            addTeacher.Controls.Add(salaryLblTch);
            addTeacher.Controls.Add(salaryBoxTch);
            addTeacher.Controls.Add(qualficationLblTch);
            addTeacher.Controls.Add(deptLblTch);
            addTeacher.Controls.Add(qualificationBoxTch);
            addTeacher.Controls.Add(deptBoxTch);
            addTeacher.Controls.Add(genderBoxTch);
            addTeacher.Controls.Add(genderLblTch);
            addTeacher.Controls.Add(addressLblTch);
            addTeacher.Controls.Add(label3);
            addTeacher.Controls.Add(LNameLblTch);
            addTeacher.Controls.Add(addressBoxTch);
            addTeacher.Controls.Add(contactBoxTch);
            addTeacher.Controls.Add(LNameBoxTch);
            addTeacher.Controls.Add(fNameBoxTch);
            addTeacher.Controls.Add(fNameLblTch);
            addTeacher.ForeColor = Color.White;
            addTeacher.Location = new Point(4, 29);
            addTeacher.Margin = new Padding(3, 4, 3, 4);
            addTeacher.Name = "addTeacher";
            addTeacher.Padding = new Padding(11, 13, 11, 13);
            addTeacher.Size = new Size(797, 439);
            addTeacher.TabIndex = 1;
            addTeacher.Text = "Add Teacher";
            // 
            // courseTchLbl
            // 
            courseTchLbl.AutoSize = true;
            courseTchLbl.ForeColor = Color.Black;
            courseTchLbl.Location = new Point(427, 294);
            courseTchLbl.Name = "courseTchLbl";
            courseTchLbl.Size = new Size(57, 20);
            courseTchLbl.TabIndex = 18;
            courseTchLbl.Text = "Course:";
            // 
            // courseBoxTch
            // 
            courseBoxTch.DropDownStyle = ComboBoxStyle.DropDownList;
            courseBoxTch.FormattingEnabled = true;
            courseBoxTch.Items.AddRange(new object[] { "DLD", "PF", "LA", "CAL", "ENG", "PS", "IS" });
            courseBoxTch.Location = new Point(534, 291);
            courseBoxTch.Margin = new Padding(3, 4, 3, 4);
            courseBoxTch.Name = "courseBoxTch";
            courseBoxTch.Size = new Size(138, 28);
            courseBoxTch.TabIndex = 17;
            // 
            // addBtnTch
            // 
            addBtnTch.ForeColor = Color.Black;
            addBtnTch.Location = new Point(309, 352);
            addBtnTch.Margin = new Padding(3, 4, 3, 4);
            addBtnTch.Name = "addBtnTch";
            addBtnTch.Size = new Size(216, 56);
            addBtnTch.TabIndex = 16;
            addBtnTch.Text = "Add";
            addBtnTch.UseVisualStyleBackColor = true;
            addBtnTch.Click += addBtnTch_Click;
            // 
            // salaryLblTch
            // 
            salaryLblTch.AutoSize = true;
            salaryLblTch.ForeColor = Color.Black;
            salaryLblTch.Location = new Point(427, 243);
            salaryLblTch.Name = "salaryLblTch";
            salaryLblTch.Size = new Size(52, 20);
            salaryLblTch.TabIndex = 15;
            salaryLblTch.Text = "Salary:";
            // 
            // salaryBoxTch
            // 
            salaryBoxTch.Location = new Point(534, 240);
            salaryBoxTch.Margin = new Padding(3, 4, 3, 4);
            salaryBoxTch.Name = "salaryBoxTch";
            salaryBoxTch.Size = new Size(138, 27);
            salaryBoxTch.TabIndex = 14;
            // 
            // qualficationLblTch
            // 
            qualficationLblTch.AutoSize = true;
            qualficationLblTch.ForeColor = Color.Black;
            qualficationLblTch.Location = new Point(427, 196);
            qualficationLblTch.Name = "qualficationLblTch";
            qualficationLblTch.Size = new Size(97, 20);
            qualficationLblTch.TabIndex = 13;
            qualficationLblTch.Text = "Qualification:";
            // 
            // deptLblTch
            // 
            deptLblTch.AutoSize = true;
            deptLblTch.ForeColor = Color.Black;
            deptLblTch.Location = new Point(427, 146);
            deptLblTch.Name = "deptLblTch";
            deptLblTch.Size = new Size(92, 20);
            deptLblTch.TabIndex = 12;
            deptLblTch.Text = "Department:";
            // 
            // qualificationBoxTch
            // 
            qualificationBoxTch.DropDownStyle = ComboBoxStyle.DropDownList;
            qualificationBoxTch.FormattingEnabled = true;
            qualificationBoxTch.Items.AddRange(new object[] { "Bacherlors", "Masters", "PHD" });
            qualificationBoxTch.Location = new Point(534, 191);
            qualificationBoxTch.Margin = new Padding(3, 4, 3, 4);
            qualificationBoxTch.Name = "qualificationBoxTch";
            qualificationBoxTch.Size = new Size(138, 28);
            qualificationBoxTch.TabIndex = 11;
            // 
            // deptBoxTch
            // 
            deptBoxTch.DropDownStyle = ComboBoxStyle.DropDownList;
            deptBoxTch.FormattingEnabled = true;
            deptBoxTch.Items.AddRange(new object[] { "Computer", "Software", "Electrical", "Social Sciences", "BBA" });
            deptBoxTch.Location = new Point(534, 140);
            deptBoxTch.Margin = new Padding(3, 4, 3, 4);
            deptBoxTch.Name = "deptBoxTch";
            deptBoxTch.Size = new Size(138, 28);
            deptBoxTch.TabIndex = 10;
            // 
            // genderBoxTch
            // 
            genderBoxTch.DropDownStyle = ComboBoxStyle.DropDownList;
            genderBoxTch.FormattingEnabled = true;
            genderBoxTch.Items.AddRange(new object[] { "Male", "Female" });
            genderBoxTch.Location = new Point(534, 91);
            genderBoxTch.Margin = new Padding(3, 4, 3, 4);
            genderBoxTch.Name = "genderBoxTch";
            genderBoxTch.Size = new Size(138, 28);
            genderBoxTch.TabIndex = 9;
            // 
            // genderLblTch
            // 
            genderLblTch.AutoSize = true;
            genderLblTch.ForeColor = Color.Black;
            genderLblTch.Location = new Point(427, 94);
            genderLblTch.Name = "genderLblTch";
            genderLblTch.Size = new Size(60, 20);
            genderLblTch.TabIndex = 8;
            genderLblTch.Text = "Gender:";
            // 
            // addressLblTch
            // 
            addressLblTch.AutoSize = true;
            addressLblTch.ForeColor = Color.Black;
            addressLblTch.Location = new Point(101, 244);
            addressLblTch.Name = "addressLblTch";
            addressLblTch.Size = new Size(65, 20);
            addressLblTch.TabIndex = 7;
            addressLblTch.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(101, 191);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Contact No:";
            // 
            // LNameLblTch
            // 
            LNameLblTch.AutoSize = true;
            LNameLblTch.ForeColor = Color.Black;
            LNameLblTch.Location = new Point(101, 140);
            LNameLblTch.Name = "LNameLblTch";
            LNameLblTch.Size = new Size(82, 20);
            LNameLblTch.TabIndex = 5;
            LNameLblTch.Text = "Last Name:";
            // 
            // addressBoxTch
            // 
            addressBoxTch.Location = new Point(199, 240);
            addressBoxTch.Margin = new Padding(3, 4, 3, 4);
            addressBoxTch.Multiline = true;
            addressBoxTch.Name = "addressBoxTch";
            addressBoxTch.Size = new Size(133, 73);
            addressBoxTch.TabIndex = 4;
            // 
            // contactBoxTch
            // 
            contactBoxTch.Location = new Point(199, 187);
            contactBoxTch.Margin = new Padding(3, 4, 3, 4);
            contactBoxTch.Name = "contactBoxTch";
            contactBoxTch.Size = new Size(133, 27);
            contactBoxTch.TabIndex = 3;
            // 
            // LNameBoxTch
            // 
            LNameBoxTch.Location = new Point(199, 136);
            LNameBoxTch.Margin = new Padding(3, 4, 3, 4);
            LNameBoxTch.Name = "LNameBoxTch";
            LNameBoxTch.Size = new Size(133, 27);
            LNameBoxTch.TabIndex = 2;
            // 
            // fNameBoxTch
            // 
            fNameBoxTch.Location = new Point(199, 84);
            fNameBoxTch.Margin = new Padding(3, 4, 3, 4);
            fNameBoxTch.Name = "fNameBoxTch";
            fNameBoxTch.Size = new Size(133, 27);
            fNameBoxTch.TabIndex = 1;
            // 
            // fNameLblTch
            // 
            fNameLblTch.AutoSize = true;
            fNameLblTch.ForeColor = Color.Black;
            fNameLblTch.Location = new Point(101, 88);
            fNameLblTch.Name = "fNameLblTch";
            fNameLblTch.Size = new Size(83, 20);
            fNameLblTch.TabIndex = 0;
            fNameLblTch.Text = "First Name:";
            // 
            // editStdTab
            // 
            editStdTab.BackColor = Color.WhiteSmoke;
            editStdTab.Controls.Add(updateBtnEdit);
            editStdTab.Controls.Add(feeLblEdit);
            editStdTab.Controls.Add(unPaidEdit);
            editStdTab.Controls.Add(paidBtnEdit);
            editStdTab.Controls.Add(addressLblInEdit);
            editStdTab.Controls.Add(contactLblInEdit);
            editStdTab.Controls.Add(addressBoxEdit);
            editStdTab.Controls.Add(contactBoxEdit);
            editStdTab.Controls.Add(lastNameBoxEdit);
            editStdTab.Controls.Add(lastNameEditLbl);
            editStdTab.Controls.Add(firstNameBoxEdit);
            editStdTab.Controls.Add(fNameLblEdit);
            editStdTab.Controls.Add(enterBtnEdit);
            editStdTab.Controls.Add(rollBoxEdit);
            editStdTab.Controls.Add(rollNoLblInEdit);
            editStdTab.Location = new Point(4, 29);
            editStdTab.Margin = new Padding(3, 4, 3, 4);
            editStdTab.Name = "editStdTab";
            editStdTab.Padding = new Padding(11, 13, 11, 13);
            editStdTab.Size = new Size(797, 439);
            editStdTab.TabIndex = 3;
            editStdTab.Text = "Edit Student";
            // 
            // updateBtnEdit
            // 
            updateBtnEdit.ForeColor = Color.Black;
            updateBtnEdit.Location = new Point(423, 359);
            updateBtnEdit.Margin = new Padding(3, 4, 3, 4);
            updateBtnEdit.Name = "updateBtnEdit";
            updateBtnEdit.Size = new Size(232, 60);
            updateBtnEdit.TabIndex = 14;
            updateBtnEdit.Text = "Update";
            updateBtnEdit.UseVisualStyleBackColor = true;
            updateBtnEdit.Click += updateBtnEdit_Click;
            // 
            // feeLblEdit
            // 
            feeLblEdit.AutoSize = true;
            feeLblEdit.ForeColor = Color.Black;
            feeLblEdit.Location = new Point(402, 312);
            feeLblEdit.Name = "feeLblEdit";
            feeLblEdit.Size = new Size(79, 20);
            feeLblEdit.TabIndex = 13;
            feeLblEdit.Text = "Fee Status:";
            // 
            // unPaidEdit
            // 
            unPaidEdit.AutoSize = true;
            unPaidEdit.ForeColor = Color.Black;
            unPaidEdit.Location = new Point(565, 312);
            unPaidEdit.Margin = new Padding(3, 4, 3, 4);
            unPaidEdit.Name = "unPaidEdit";
            unPaidEdit.Size = new Size(78, 24);
            unPaidEdit.TabIndex = 12;
            unPaidEdit.TabStop = true;
            unPaidEdit.Text = "Unpaid";
            unPaidEdit.UseVisualStyleBackColor = true;
            // 
            // paidBtnEdit
            // 
            paidBtnEdit.AutoSize = true;
            paidBtnEdit.ForeColor = Color.Black;
            paidBtnEdit.Location = new Point(503, 312);
            paidBtnEdit.Margin = new Padding(3, 4, 3, 4);
            paidBtnEdit.Name = "paidBtnEdit";
            paidBtnEdit.Size = new Size(58, 24);
            paidBtnEdit.TabIndex = 11;
            paidBtnEdit.TabStop = true;
            paidBtnEdit.Text = "Paid";
            paidBtnEdit.UseVisualStyleBackColor = true;
            // 
            // addressLblInEdit
            // 
            addressLblInEdit.AutoSize = true;
            addressLblInEdit.ForeColor = Color.Black;
            addressLblInEdit.Location = new Point(402, 221);
            addressLblInEdit.Name = "addressLblInEdit";
            addressLblInEdit.Size = new Size(65, 20);
            addressLblInEdit.TabIndex = 10;
            addressLblInEdit.Text = "Address:";
            // 
            // contactLblInEdit
            // 
            contactLblInEdit.AutoSize = true;
            contactLblInEdit.ForeColor = Color.Black;
            contactLblInEdit.Location = new Point(402, 137);
            contactLblInEdit.Name = "contactLblInEdit";
            contactLblInEdit.Size = new Size(87, 20);
            contactLblInEdit.TabIndex = 9;
            contactLblInEdit.Text = "Contact No:";
            // 
            // addressBoxEdit
            // 
            addressBoxEdit.Location = new Point(495, 188);
            addressBoxEdit.Margin = new Padding(3, 4, 3, 4);
            addressBoxEdit.Multiline = true;
            addressBoxEdit.Name = "addressBoxEdit";
            addressBoxEdit.Size = new Size(158, 89);
            addressBoxEdit.TabIndex = 8;
            // 
            // contactBoxEdit
            // 
            contactBoxEdit.Location = new Point(495, 137);
            contactBoxEdit.Margin = new Padding(3, 4, 3, 4);
            contactBoxEdit.Name = "contactBoxEdit";
            contactBoxEdit.Size = new Size(158, 27);
            contactBoxEdit.TabIndex = 7;
            // 
            // lastNameBoxEdit
            // 
            lastNameBoxEdit.Location = new Point(495, 87);
            lastNameBoxEdit.Margin = new Padding(3, 4, 3, 4);
            lastNameBoxEdit.Name = "lastNameBoxEdit";
            lastNameBoxEdit.Size = new Size(158, 27);
            lastNameBoxEdit.TabIndex = 6;
            // 
            // lastNameEditLbl
            // 
            lastNameEditLbl.AutoSize = true;
            lastNameEditLbl.ForeColor = Color.Black;
            lastNameEditLbl.Location = new Point(402, 94);
            lastNameEditLbl.Name = "lastNameEditLbl";
            lastNameEditLbl.Size = new Size(82, 20);
            lastNameEditLbl.TabIndex = 5;
            lastNameEditLbl.Text = "Last Name:";
            // 
            // firstNameBoxEdit
            // 
            firstNameBoxEdit.Location = new Point(495, 31);
            firstNameBoxEdit.Margin = new Padding(3, 4, 3, 4);
            firstNameBoxEdit.Name = "firstNameBoxEdit";
            firstNameBoxEdit.Size = new Size(158, 27);
            firstNameBoxEdit.TabIndex = 4;
            // 
            // fNameLblEdit
            // 
            fNameLblEdit.AutoSize = true;
            fNameLblEdit.ForeColor = Color.Black;
            fNameLblEdit.Location = new Point(402, 38);
            fNameLblEdit.Name = "fNameLblEdit";
            fNameLblEdit.Size = new Size(83, 20);
            fNameLblEdit.TabIndex = 3;
            fNameLblEdit.Text = "First Name:";
            // 
            // enterBtnEdit
            // 
            enterBtnEdit.ForeColor = Color.Black;
            enterBtnEdit.Location = new Point(133, 188);
            enterBtnEdit.Margin = new Padding(3, 4, 3, 4);
            enterBtnEdit.Name = "enterBtnEdit";
            enterBtnEdit.Size = new Size(138, 37);
            enterBtnEdit.TabIndex = 2;
            enterBtnEdit.Text = "Enter";
            enterBtnEdit.UseVisualStyleBackColor = true;
            enterBtnEdit.Click += enterBtnEdit_Click;
            // 
            // rollBoxEdit
            // 
            rollBoxEdit.Location = new Point(133, 132);
            rollBoxEdit.Margin = new Padding(3, 4, 3, 4);
            rollBoxEdit.Multiline = true;
            rollBoxEdit.Name = "rollBoxEdit";
            rollBoxEdit.Size = new Size(156, 35);
            rollBoxEdit.TabIndex = 1;
            // 
            // rollNoLblInEdit
            // 
            rollNoLblInEdit.AutoSize = true;
            rollNoLblInEdit.ForeColor = Color.Black;
            rollNoLblInEdit.Location = new Point(70, 136);
            rollNoLblInEdit.Name = "rollNoLblInEdit";
            rollNoLblInEdit.Size = new Size(62, 20);
            rollNoLblInEdit.TabIndex = 0;
            rollNoLblInEdit.Text = "Roll No:";
            // 
            // editTeacher
            // 
            editTeacher.BackColor = Color.WhiteSmoke;
            editTeacher.Controls.Add(qualificationBoxTchEdit);
            editTeacher.Controls.Add(QualificationLblTchEdit);
            editTeacher.Controls.Add(updateBtnTchEdit);
            editTeacher.Controls.Add(tidBoxEdit);
            editTeacher.Controls.Add(tIdLbl);
            editTeacher.Controls.Add(enterBtnEditTch);
            editTeacher.Controls.Add(label4);
            editTeacher.Controls.Add(label5);
            editTeacher.Controls.Add(salaryLblEdit);
            editTeacher.Controls.Add(addressBoxEditTch);
            editTeacher.Controls.Add(salaryBoxEdit);
            editTeacher.Controls.Add(contactBoxEditTch);
            editTeacher.Location = new Point(4, 29);
            editTeacher.Margin = new Padding(3, 4, 3, 4);
            editTeacher.Name = "editTeacher";
            editTeacher.Size = new Size(797, 439);
            editTeacher.TabIndex = 4;
            editTeacher.Text = "Edit Teacher";
            // 
            // qualificationBoxTchEdit
            // 
            qualificationBoxTchEdit.FormattingEnabled = true;
            qualificationBoxTchEdit.Items.AddRange(new object[] { "Bacherlors", "Masters", "PHD" });
            qualificationBoxTchEdit.Location = new Point(489, 65);
            qualificationBoxTchEdit.Margin = new Padding(3, 4, 3, 4);
            qualificationBoxTchEdit.Name = "qualificationBoxTchEdit";
            qualificationBoxTchEdit.Size = new Size(158, 28);
            qualificationBoxTchEdit.TabIndex = 31;
            // 
            // QualificationLblTchEdit
            // 
            QualificationLblTchEdit.AutoSize = true;
            QualificationLblTchEdit.ForeColor = Color.Black;
            QualificationLblTchEdit.Location = new Point(398, 69);
            QualificationLblTchEdit.Name = "QualificationLblTchEdit";
            QualificationLblTchEdit.Size = new Size(97, 20);
            QualificationLblTchEdit.TabIndex = 30;
            QualificationLblTchEdit.Text = "Qualification:";
            // 
            // updateBtnTchEdit
            // 
            updateBtnTchEdit.ForeColor = Color.Black;
            updateBtnTchEdit.Location = new Point(416, 349);
            updateBtnTchEdit.Margin = new Padding(3, 4, 3, 4);
            updateBtnTchEdit.Name = "updateBtnTchEdit";
            updateBtnTchEdit.Size = new Size(232, 60);
            updateBtnTchEdit.TabIndex = 29;
            updateBtnTchEdit.Text = "Update";
            updateBtnTchEdit.UseVisualStyleBackColor = true;
            updateBtnTchEdit.Click += updateBtnTchEdit_Click;
            // 
            // tidBoxEdit
            // 
            tidBoxEdit.Location = new Point(134, 124);
            tidBoxEdit.Margin = new Padding(3, 4, 3, 4);
            tidBoxEdit.Multiline = true;
            tidBoxEdit.Name = "tidBoxEdit";
            tidBoxEdit.Size = new Size(156, 35);
            tidBoxEdit.TabIndex = 16;
            // 
            // tIdLbl
            // 
            tIdLbl.AutoSize = true;
            tIdLbl.ForeColor = Color.Black;
            tIdLbl.Location = new Point(48, 133);
            tIdLbl.Name = "tIdLbl";
            tIdLbl.Size = new Size(82, 20);
            tIdLbl.TabIndex = 15;
            tIdLbl.Text = "Teacher ID:";
            // 
            // enterBtnEditTch
            // 
            enterBtnEditTch.ForeColor = Color.Black;
            enterBtnEditTch.Location = new Point(134, 180);
            enterBtnEditTch.Margin = new Padding(3, 4, 3, 4);
            enterBtnEditTch.Name = "enterBtnEditTch";
            enterBtnEditTch.Size = new Size(138, 37);
            enterBtnEditTch.TabIndex = 17;
            enterBtnEditTch.Text = "Enter";
            enterBtnEditTch.UseVisualStyleBackColor = true;
            enterBtnEditTch.Click += enterBtnEditTch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(398, 255);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 25;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(398, 175);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 24;
            label5.Text = "Contact No:";
            // 
            // salaryLblEdit
            // 
            salaryLblEdit.AutoSize = true;
            salaryLblEdit.ForeColor = Color.Black;
            salaryLblEdit.Location = new Point(398, 124);
            salaryLblEdit.Name = "salaryLblEdit";
            salaryLblEdit.Size = new Size(52, 20);
            salaryLblEdit.TabIndex = 20;
            salaryLblEdit.Text = "Salary:";
            // 
            // addressBoxEditTch
            // 
            addressBoxEditTch.Location = new Point(489, 221);
            addressBoxEditTch.Margin = new Padding(3, 4, 3, 4);
            addressBoxEditTch.Multiline = true;
            addressBoxEditTch.Name = "addressBoxEditTch";
            addressBoxEditTch.Size = new Size(158, 89);
            addressBoxEditTch.TabIndex = 23;
            // 
            // salaryBoxEdit
            // 
            salaryBoxEdit.Location = new Point(489, 120);
            salaryBoxEdit.Margin = new Padding(3, 4, 3, 4);
            salaryBoxEdit.Name = "salaryBoxEdit";
            salaryBoxEdit.Size = new Size(158, 27);
            salaryBoxEdit.TabIndex = 21;
            // 
            // contactBoxEditTch
            // 
            contactBoxEditTch.Location = new Point(489, 171);
            contactBoxEditTch.Margin = new Padding(3, 4, 3, 4);
            contactBoxEditTch.Name = "contactBoxEditTch";
            contactBoxEditTch.Size = new Size(158, 27);
            contactBoxEditTch.TabIndex = 22;
            // 
            // viewStudents
            // 
            viewStudents.BackColor = Color.WhiteSmoke;
            viewStudents.Controls.Add(showBtn);
            viewStudents.Controls.Add(viewByRollPnl);
            viewStudents.Controls.Add(viewByDept);
            viewStudents.Controls.Add(viewStdBox);
            viewStudents.Controls.Add(studentGrid);
            viewStudents.ForeColor = Color.Black;
            viewStudents.Location = new Point(4, 29);
            viewStudents.Margin = new Padding(3, 4, 3, 4);
            viewStudents.Name = "viewStudents";
            viewStudents.Padding = new Padding(11, 13, 11, 13);
            viewStudents.Size = new Size(797, 439);
            viewStudents.TabIndex = 2;
            viewStudents.Text = "View Students";
            // 
            // showBtn
            // 
            showBtn.Location = new Point(361, 112);
            showBtn.Margin = new Padding(3, 4, 3, 4);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(86, 31);
            showBtn.TabIndex = 4;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // viewByRollPnl
            // 
            viewByRollPnl.Controls.Add(rollNoInViewBox);
            viewByRollPnl.Controls.Add(rollNoLblInView);
            viewByRollPnl.Controls.Add(label1);
            viewByRollPnl.Location = new Point(289, 53);
            viewByRollPnl.Margin = new Padding(3, 4, 3, 4);
            viewByRollPnl.Name = "viewByRollPnl";
            viewByRollPnl.Size = new Size(229, 53);
            viewByRollPnl.TabIndex = 3;
            viewByRollPnl.Visible = false;
            // 
            // rollNoInViewBox
            // 
            rollNoInViewBox.Location = new Point(83, 14);
            rollNoInViewBox.Margin = new Padding(3, 4, 3, 4);
            rollNoInViewBox.Name = "rollNoInViewBox";
            rollNoInViewBox.Size = new Size(132, 27);
            rollNoInViewBox.TabIndex = 2;
            // 
            // rollNoLblInView
            // 
            rollNoLblInView.AutoSize = true;
            rollNoLblInView.ForeColor = Color.Black;
            rollNoLblInView.Location = new Point(15, 17);
            rollNoLblInView.Name = "rollNoLblInView";
            rollNoLblInView.Size = new Size(62, 20);
            rollNoLblInView.TabIndex = 1;
            rollNoLblInView.Text = "Roll No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // viewByDept
            // 
            viewByDept.Controls.Add(deptInViewBox);
            viewByDept.Location = new Point(338, 57);
            viewByDept.Margin = new Padding(3, 4, 3, 4);
            viewByDept.Name = "viewByDept";
            viewByDept.Size = new Size(138, 47);
            viewByDept.TabIndex = 3;
            viewByDept.Visible = false;
            // 
            // deptInViewBox
            // 
            deptInViewBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deptInViewBox.FormattingEnabled = true;
            deptInViewBox.Items.AddRange(new object[] { "Computer", "Software", "Electrical", "Social Sciences", "BBA" });
            deptInViewBox.Location = new Point(-3, 4);
            deptInViewBox.Margin = new Padding(3, 4, 3, 4);
            deptInViewBox.Name = "deptInViewBox";
            deptInViewBox.Size = new Size(138, 28);
            deptInViewBox.TabIndex = 0;
            // 
            // viewStdBox
            // 
            viewStdBox.DropDownStyle = ComboBoxStyle.DropDownList;
            viewStdBox.FormattingEnabled = true;
            viewStdBox.Items.AddRange(new object[] { "View All Students", "View By Department", "View By RollNo" });
            viewStdBox.Location = new Point(338, 17);
            viewStdBox.Margin = new Padding(3, 4, 3, 4);
            viewStdBox.Name = "viewStdBox";
            viewStdBox.Size = new Size(138, 28);
            viewStdBox.TabIndex = 2;
            viewStdBox.SelectedIndexChanged += viewStdBox_SelectedIndexChanged;
            // 
            // studentGrid
            // 
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Location = new Point(15, 152);
            studentGrid.Margin = new Padding(3, 4, 3, 4);
            studentGrid.Name = "studentGrid";
            studentGrid.RowHeadersWidth = 51;
            studentGrid.RowTemplate.Height = 25;
            studentGrid.Size = new Size(766, 247);
            studentGrid.TabIndex = 0;
            // 
            // viewTeachers
            // 
            viewTeachers.BackColor = Color.WhiteSmoke;
            viewTeachers.Controls.Add(teacherGrid);
            viewTeachers.ForeColor = Color.Black;
            viewTeachers.Location = new Point(4, 29);
            viewTeachers.Margin = new Padding(3, 4, 3, 4);
            viewTeachers.Name = "viewTeachers";
            viewTeachers.Size = new Size(797, 439);
            viewTeachers.TabIndex = 5;
            viewTeachers.Text = "View Teachers";
            // 
            // teacherGrid
            // 
            teacherGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherGrid.Location = new Point(15, 50);
            teacherGrid.Margin = new Padding(3, 4, 3, 4);
            teacherGrid.Name = "teacherGrid";
            teacherGrid.RowHeadersWidth = 51;
            teacherGrid.RowTemplate.Height = 25;
            teacherGrid.Size = new Size(766, 339);
            teacherGrid.TabIndex = 1;
            // 
            // logoutLBl
            // 
            logoutLBl.AutoSize = true;
            logoutLBl.BackColor = Color.DarkGray;
            logoutLBl.Cursor = Cursors.Hand;
            logoutLBl.ForeColor = Color.White;
            logoutLBl.Location = new Point(851, 9);
            logoutLBl.Name = "logoutLBl";
            logoutLBl.Size = new Size(56, 20);
            logoutLBl.TabIndex = 6;
            logoutLBl.Text = "Logout";
            logoutLBl.Click += logoutLBl_Click;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(919, 516);
            Controls.Add(logoutLBl);
            Controls.Add(adminTAB);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flex | Admin Form";
            Load += adminForm_Load;
            adminTAB.ResumeLayout(false);
            addStudent.ResumeLayout(false);
            addStudent.PerformLayout();
            addTeacher.ResumeLayout(false);
            addTeacher.PerformLayout();
            editStdTab.ResumeLayout(false);
            editStdTab.PerformLayout();
            editTeacher.ResumeLayout(false);
            editTeacher.PerformLayout();
            viewStudents.ResumeLayout(false);
            viewByRollPnl.ResumeLayout(false);
            viewByRollPnl.PerformLayout();
            viewByDept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            viewTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teacherGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl adminTAB;
        private TabPage addStudent;
        private Button addStudentBtn;
        private Label lastNameLbl;
        private TextBox lastNameBox;
        private Label firstNameLbl;
        private TabPage addTeacher;
        private TabPage viewStudents;
        private TabPage editStdTab;
        private TabPage editTeacher;
        private ComboBox deptBox;
        private Label deptLbl;
        private ComboBox QualificationBox;
        private Label qualificationLbl;
        private ComboBox genderBox;
        private Label genderLbl;
        private TextBox contactBox;
        private Label contactLbl;
        private TextBox firstNameBox;
        private ComboBox bloodGroupBox;
        private Label bloodLbl;
        private Label addressLbl;
        private TextBox addressBox;
        private RadioButton UnpaidBtn;
        private RadioButton paidButton;
        private Label feeStatLbl;
        private DataGridView studentGrid;
        private Panel viewByDept;
        private ComboBox deptInViewBox;
        private ComboBox viewStdBox;
        private Panel viewByRollPnl;
        private Label label1;
        private TextBox rollNoInViewBox;
        private Label rollNoLblInView;
        private Button showBtn;
        private Label addressLblInEdit;
        private Label contactLblInEdit;
        private TextBox addressBoxEdit;
        private TextBox contactBoxEdit;
        private TextBox lastNameBoxEdit;
        private Label lastNameEditLbl;
        private TextBox firstNameBoxEdit;
        private Label fNameLblEdit;
        private Button enterBtnEdit;
        private TextBox rollBoxEdit;
        private Label rollNoLblInEdit;
        private RadioButton paidBtnEdit;
        private RadioButton unPaidEdit;
        private Label feeLblEdit;
        private Button updateBtnEdit;
        private Label fNameLblTch;
        private TextBox fNameBoxTch;
        private Label addressLblTch;
        private Label label3;
        private Label LNameLblTch;
        private TextBox addressBoxTch;
        private TextBox contactBoxTch;
        private TextBox LNameBoxTch;
        private Label genderLblTch;
        private Label deptLblTch;
        private ComboBox qualificationBoxTch;
        private ComboBox deptBoxTch;
        private ComboBox genderBoxTch;
        private Label qualficationLblTch;
        private Label salaryLblTch;
        private TextBox salaryBoxTch;
        private Button addBtnTch;
        private Button updateBtnTchEdit;
        private TextBox tidBoxEdit;
        private Label tIdLbl;
        private Button enterBtnEditTch;
        private Label label7;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label salaryLblEdit;
        private TextBox addressBoxEditTch;
        private TextBox salaryBoxEdit;
        private TextBox contactBoxEditTch;
        private ComboBox qualificationBoxTchEdit;
        private Label QualificationLblTchEdit;
        private TabPage viewTeachers;
        private Label courseLbl;
        private CheckedListBox courseBox;
        private Label courseTchLbl;
        private ComboBox courseBoxTch;
        private DataGridView teacherGrid;
        private Label logoutLBl;
    }
}