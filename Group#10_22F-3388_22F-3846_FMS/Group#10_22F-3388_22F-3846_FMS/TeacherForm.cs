using Newtonsoft.Json;
using StudentManagementSystem;
using System.Data;
using static adminFile.admin;
namespace Group_10_22F_3388_22F_3846_FMS
{
    public partial class teacherForm : Form
    {
        public static string department;
        public static Teacher thisTeacher;
        public teacherForm()
        {
            InitializeComponent();
            thisTeacher = new Teacher();
            thisTeacher.tid = "";
            thisTeacher.Course = "";
        }
        public teacherForm(Teacher teacher)
        {
            InitializeComponent();
            thisTeacher = teacher;
        }
        public DataTable LoadStudentMarks()
        {


            // Read the student data from the JSON file
            string fileContents = System.IO.File.ReadAllText(Studentpath);
            if (fileContents == string.Empty)
            {
                MessageBox.Show("File not found", "ERROR");
                // adminForm.Close();
                logout();
            }
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);

            // Create a DataTable to store the student data
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Quiz 1");
            dt.Columns.Add("Quiz 2");
            dt.Columns.Add("Quiz 3");
            dt.Columns.Add("Quiz 4");
            dt.Columns.Add("Assignment 1");
            dt.Columns.Add("Assignment 2");
            dt.Columns.Add("Assignment 3");
            dt.Columns.Add("Mid 1");
            dt.Columns.Add("Mid 2");
            dt.Columns.Add("Final");

            foreach (Student student in students)
            {
                for (int i = 0; i < student.Course.Length; i++)
                {
                    if (student.Course[i].CourseName == thisTeacher.Course)
                    {
                        DataRow row = dt.NewRow();
                        row["Roll No"] = student.RollNo;
                        row["Quiz 1"] = student.Course[i].marks.Quiz[0].ToString();
                        row["Quiz 2"] = student.Course[i].marks.Quiz[1].ToString();
                        row["Quiz 3"] = student.Course[i].marks.Quiz[2].ToString();
                        row["Quiz 4"] = student.Course[i].marks.Quiz[3].ToString();

                        row["Assignment 1"] = student.Course[i].marks.Assignment[0].ToString();
                        row["Assignment 2"] = student.Course[i].marks.Assignment[1].ToString();
                        row["Assignment 3"] = student.Course[i].marks.Assignment[2].ToString();

                        row["Mid 1"] = student.Course[i].marks.Mid[0].ToString();
                        row["Mid 2"] = student.Course[i].marks.Mid[1].ToString();

                        row["Final"] = student.Course[i].marks.final.ToString();

                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }
        public DataTable LoadStudentMarks(string key)
        {


            string fileContents = System.IO.File.ReadAllText(Studentpath);
            if (fileContents == string.Empty)
            {
                MessageBox.Show("File not found", "ERROR");
                logout();
            }
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);
            Student student = students.FirstOrDefault(s => s.RollNo == key.ToUpper());
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Quiz 1");
            dt.Columns.Add("Quiz 2");
            dt.Columns.Add("Quiz 3");
            dt.Columns.Add("Quiz 4");
            dt.Columns.Add("Assignment 1");
            dt.Columns.Add("Assignment 2");
            dt.Columns.Add("Assignment 3");
            dt.Columns.Add("Mid 1");
            dt.Columns.Add("Mid 2");
            dt.Columns.Add("Final");
            if (student == null)
            {
                MessageBox.Show("No student found!", "Incorrect roll no");
            }
            else
            {
                // Create a DataTable to store the student data\
                for (int i = 0; i < student.Course.Length; i++)
                {
                    if (student.Course[i].CourseName == thisTeacher.Course)
                    {
                        DataRow row = dt.NewRow();
                        row["Roll No"] = student.RollNo;
                        row["Quiz 1"] = student.Course[i].marks.Quiz[0].ToString();
                        row["Quiz 2"] = student.Course[i].marks.Quiz[1].ToString();
                        row["Quiz 3"] = student.Course[i].marks.Quiz[2].ToString();
                        row["Quiz 4"] = student.Course[i].marks.Quiz[3].ToString();

                        row["Assignment 1"] = student.Course[i].marks.Assignment[0].ToString();
                        row["Assignment 2"] = student.Course[i].marks.Assignment[1].ToString();
                        row["Assignment 3"] = student.Course[i].marks.Assignment[2].ToString();

                        row["Mid 1"] = student.Course[i].marks.Mid[0].ToString();
                        row["Mid 2"] = student.Course[i].marks.Mid[1].ToString();

                        row["Final"] = student.Course[i].marks.final.ToString();

                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }
        public DataTable LoadStudentGrades()
        {

            // Read the student data from the JSON file
            string fileContents = System.IO.File.ReadAllText(Studentpath);
            if (fileContents == string.Empty)
            {
                MessageBox.Show("File not found", "ERROR");
            }
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);

            // Create a DataTable to store the student data
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Course");

            dt.Columns.Add("Grade");

            foreach (Student student in students)
            {

                for (int i = 0; i < student.Course.Length; i++)
                {
                    if (student.Course[i].CourseName == thisTeacher.Course)
                    {
                        DataRow row = dt.NewRow();
                        row["Roll No"] = student.RollNo;
                        row["Course"] = student.Course[i].CourseName.ToString();
                        row["Grade"] = student.Course[i].Grade;

                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }
        public DataTable LoadStudentAttendance()
        {
            // Read the student data from the JSON file
            string fileContents = System.IO.File.ReadAllText(Studentpath);
            if (fileContents == string.Empty)
            {
                MessageBox.Show("File not found", "ERROR");
                logout();
            }
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);

            // Create a DataTable to store the student data
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Name");
            dt.Columns.Add("PRESENT?", typeof(bool));

            foreach (Student student in students)
            {

                for (int i = 0; i < student.Course.Length; i++)
                {
                    if (student.Course[i].CourseName == thisTeacher.Course)
                    {
                        DataRow row = dt.NewRow();
                        row["Roll No"] = student.RollNo;
                        row["Name"] = student.Fname + " " + student.Lname;
                        for (int j = 0; j < student.Course[i].attendance.Count; ++j)
                        {
                            if (student.Course[i].attendance[j].Date == dateTimePicker1.Value.ToString("dd/MM/yyyy"))
                                row["PRESENT?"] = student.Course[i].attendance[j].Status;
                        }
                        dt.Rows.Add(row);
                    }
                }
            }

            return dt;
        }
        public DataTable LoadStudentAttendance(string roll, string date)
        {

            // Read the student data from the JSON file
            string fileContents = System.IO.File.ReadAllText(Studentpath);
            if (fileContents == string.Empty)
            {
                MessageBox.Show("File not found", "ERROR");
                logout();
            }
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);
            Student student = students.FirstOrDefault(s => s.RollNo == roll);
            // Create a DataTable to store the student data
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Name");
            dt.Columns.Add("PRESENT?", typeof(bool));


            //if(student.RollNo == roll && Ro)
            for (int i = 0; i < student.Course.Length; i++)
            {
                if (student.Course[i].CourseName == thisTeacher.Course)
                {
                    DataRow row = dt.NewRow();
                    row["Roll No"] = student.RollNo;
                    row["Name"] = student.Fname + " " + student.Lname;
                    for (int j = 0; j < student.Course[i].attendance.Count; ++j)
                        if (student.Course[i].attendance[j].Date == date)
                            row["PRESENT?"] = student.Course[i].attendance[j].Status;
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }
        public DataTable UpdateStudentAttendance(string roll, string date)
        {
            DataTable dt = (DataTable)attendanceGrid.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {

                // Iterate over each row in the dataGridView1 control
                string fileContents = System.IO.File.ReadAllText(Studentpath);
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);
                Student student = students.FirstOrDefault(s => s.RollNo == roll);
                bool flag = true;
                foreach (DataGridViewRow row in attendanceGrid.Rows)
                {

                    bool status = Convert.ToBoolean(row.Cells["PRESENT?"].Value);

                    // Update the Student object
                    for (int h = 0; h < students.Count; ++h)
                    {
                        for (int i = 0; i < students[h].Course.Length; i++)
                        {
                            for (int j = 0; j < students[h].Course[i].attendance.Count; ++j)
                            {
                                if (students[h].Course[i].CourseName == thisTeacher.Course)
                                    if (students[h].Course[i].attendance[j].Date == date && students[h].RollNo == roll)
                                    {
                                        students[h].Course[i].attendance[j].Status = (bool)row.Cells["PRESENT?"].Value;
                                        flag = false;
                                    }
                            }
                            if (flag)
                            {
                                if (students[h].Course[i].CourseName == thisTeacher.Course)
                                    if (students[h].RollNo == roll)
                                    {
                                        Attendance a = new();
                                        a.Date = date;
                                        a.Status = (bool)row.Cells["PRESENT?"].Value;
                                        students[h].Course[i].attendance.Add(a);
                                    }
                            }
                        }
                    }
                }
                WriteJsonFile<Student>(students, Studentpath);

            }
            else
            {
                MessageBox.Show("Error", "error");
            }

            return dt;
        }
        public DataTable LoadStudentGrades(string roll)
        {


            // Read the student data from the JSON file
            string fileContents = System.IO.File.ReadAllText(Studentpath);
            if (fileContents == string.Empty)
            {
                MessageBox.Show("File not found", "ERROR");
                logout();
            }
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);

            Student student = students.FirstOrDefault(s => s.RollNo == roll);
            // Create a DataTable to store the student data
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Course");
            dt.Columns.Add("Grade");
            if (student == null)
            {
                MessageBox.Show("No student found!", "Incorrect roll no");
            }
            else
            {
                // Create a DataTable to store the student data


                for (int i = 0; i < student.Course.Length; i++)
                {
                    if (student.Course[i].CourseName == thisTeacher.Course)
                    {
                        DataRow row = dt.NewRow();
                        row["Roll No"] = student.RollNo;
                        row["Course"] = student.Course[i].CourseName.ToString();
                        row["Grade"] = student.Course[i].Grade;
                        dt.Rows.Add(row);
                    }
                }
            }

            return dt;
        }
        public void loadHomePage()
        {

            FNameTeacherTxt.Text = thisTeacher.Fname;
            lastNameTeacherTxt.Text = thisTeacher.Lname;
            ContactTeacherTxt.Text = thisTeacher.ContactNo;
            DepTeacherTxt.Text = thisTeacher.Department;
            QualificationTeacherTxt.Text = thisTeacher.Qualification;
            AdressTeacherTxt.Text = thisTeacher.Address;
            salaryTxt.Text = "Rs. " + thisTeacher.Salary;
            genderTxt.Text = thisTeacher.Gender;
        }

        private void teacherForm_Load(object sender, EventArgs e)
        {
            updateMarksGrid.DataSource = LoadStudentMarks();
            timetableGrid.DataSource = Teacher.ShowTimetable(thisTeacher.Department);
            loadHomePage();
            attendanceGrid.DataSource = LoadStudentAttendance();
        }

        private void enterBtnEdit_Click(object sender, EventArgs e)
        {
            updateMarksGrid.DataSource = LoadStudentMarks(rollBoxTchMarks.Text);
            List<Student> students = ReadJsonFile<Student>(Studentpath);
            Student student = students.FirstOrDefault(s => s.RollNo == rollBoxTchMarks.Text.ToUpper());
            if (student != null)
            {
                firstNameBoxTchMarks.Text = student.Fname;
                lastNameBoxTchMarks.Text = student.Lname;
            }
        }


        public void updateStudent(string rollNo)
        {
            DataTable dt = (DataTable)updateMarksGrid.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {

                string fileContents = System.IO.File.ReadAllText(Studentpath);
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);
                foreach (DataGridViewRow row in updateMarksGrid.Rows)
                {
                    // Get the updated marks for each quiz, assignment, mid, and final              ;
                    string roll = Convert.ToString(row.Cells["Roll No"].Value);
                    double quiz1 = Convert.ToDouble(row.Cells["Quiz 1"].Value);
                    double quiz2 = Convert.ToDouble(row.Cells["Quiz 2"].Value);
                    double quiz3 = Convert.ToDouble(row.Cells["Quiz 3"].Value);
                    double quiz4 = Convert.ToDouble(row.Cells["Quiz 4"].Value);

                    int assignment1 = Convert.ToInt32(row.Cells["Assignment 1"].Value);
                    int assignment2 = Convert.ToInt32(row.Cells["Assignment 2"].Value);
                    int assignment3 = Convert.ToInt32(row.Cells["Assignment 3"].Value);

                    int mid1 = Convert.ToInt32(row.Cells["Mid 1"].Value);
                    int mid2 = Convert.ToInt32(row.Cells["Mid 2"].Value);

                    int final = Convert.ToInt32(row.Cells["Final"].Value);

                    // Update the Student object
                    for (int i = 0; i < students.Count; ++i)
                    {
                        for (int j = 0; j < students[i].Course.Length; j++)
                        {
                            if (students[i].RollNo == rollNo && rollNo == roll)
                                if (students[i].Course[j].CourseName == thisTeacher.Course)
                                {
                                    students[i].Course[j].marks.Quiz = new double[] { quiz1, quiz2, quiz3, quiz4 };
                                    students[i].Course[j].marks.Assignment = new float[] { assignment1, assignment2, assignment3 };
                                    students[i].Course[j].marks.Mid = new float[] { mid1, mid2 };
                                    students[i].Course[j].marks.final = final;
                                }
                        }

                    }
                }

                WriteJsonFile<Student>(students, Studentpath);

                // Show a success message
                MessageBox.Show("Marks updated successfully!", "Success");
            }
            else
            {
                // Show an error message
                MessageBox.Show("No student found with the given roll number!", "Error");
            }
        }
        public void updateStudentGrade(string rollNo)
        {
            DataTable dt = (DataTable)gradeGrid.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {


                // Iterate over each row in the dataGridView1 control
                string fileContents = System.IO.File.ReadAllText(Studentpath);
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);
                foreach (DataGridViewRow row in gradeGrid.Rows)
                {
                    // Get the updated marks for each quiz, assignment, mid, and final
                    string roll = Convert.ToString(row.Cells["Roll No"].Value);
                    string course = Convert.ToString(row.Cells["Course"].Value);
                    string grade = Convert.ToString(row.Cells["Grade"].Value);


                    // Update the Student object
                    for (int i = 0; i < students.Count; ++i)
                    {
                        for (int j = 0; j < students[i].Course.Length; j++)
                        {
                            if (students[i].RollNo == rollNo && rollNo == roll)
                                if (students[i].Course[j].CourseName == thisTeacher.Course)
                                {
                                    students[i].Course[j].Grade = Convert.ToString(grade);
                                    students[i].Course[j].CourseName = course;

                                }
                        }

                    }
                }

                WriteJsonFile<Student>(students, Studentpath);

                // Show a success message
                MessageBox.Show("Grade updated successfully!", "Success");
            }
            else
            {
                // Show an error message
                MessageBox.Show("No student found with the given roll number!", "Error");
            }
        }

        private void updateBtnEdit_Click(object sender, EventArgs e)
        {
            string rollNo = rollBoxTchMarks.Text.ToUpper();
            updateStudent(rollNo);

        }

        private void updateMarksGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol1.SelectedIndex == 1)
                updateMarksGrid.DataSource = LoadStudentMarks();
            if (tabcontrol1.SelectedIndex == 2)
                gradeGrid.DataSource = LoadStudentGrades();

        }

        private void updateGradeBtn_Click(object sender, EventArgs e)
        {
            string rollNo = rollNoGrade.Text.ToUpper();
            updateStudentGrade(rollNo);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {


        }

        private void enterBtnGrades_Click(object sender, EventArgs e)
        {
            gradeGrid.DataSource = LoadStudentGrades(rollNoGrade.Text.ToUpper());
            List<Student> students = ReadJsonFile<Student>(Studentpath);

            Student student = students.FirstOrDefault(s => s.RollNo == rollNoGrade.Text.ToUpper());
            if (student != null)
            {
                fNameGrade.Text = student.Fname;
                lNameGrade.Text = student.Lname;
            }
        }

        private void enterAttendanceBTn_Click(object sender, EventArgs e)
        {
            string roll = rollNoBoxAttendance.Text.ToUpper();
            List<Student> students = ReadJsonFile<Student>(Studentpath);
            Student student = students.FirstOrDefault(s => s.RollNo == roll);
            if (student != null)
            {

                attendanceGrid.DataSource = LoadStudentAttendance(roll, dateTimePicker1.Value.ToString("dd/MM/yyyy"));

            }
            else
            {
                MessageBox.Show("Student not found", "OHNO!");

            }
        }

        private void updateAttendanceBtn_Click(object sender, EventArgs e)
        {
            string roll = rollNoBoxAttendance.Text.ToUpper();
            List<Student> students = ReadJsonFile<Student>(Studentpath);
            Student student = students.FirstOrDefault(s => s.RollNo == roll);
            if (student != null)
            {
                UpdateStudentAttendance(roll, dateTimePicker1.Value.ToString("dd/MM/yyyy")); ;
                MessageBox.Show("Attendance marked!", "Succesfull");
            }
            else
            {
                MessageBox.Show("Student not found", "OHNO!");

            }

        }
        public void logout()
        {
            this.Close();
            LoginForm loginForm1 = new LoginForm();
            loginForm1.Show();
        }
        private void logOutImage_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logoutLBl_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void rollNoLblAttendance_Click(object sender, EventArgs e)
        {

        }

        private void QualificationTeacherTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
