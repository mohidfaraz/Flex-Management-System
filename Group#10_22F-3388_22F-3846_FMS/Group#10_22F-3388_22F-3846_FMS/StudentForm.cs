using StudentManagementSystem;
using System.Data;
namespace Group_10_22F_3388_22F_3846_FMS
{
    public partial class studentForm : Form
    {
        Student thisStudent;
        public studentForm()
        {
            InitializeComponent();

        }
        public studentForm(Student thisStudent)
        {

            InitializeComponent();
            this.thisStudent = thisStudent;
        }
        public void loadHomePage()
        {
            FNameStdBox.Text = thisStudent.Fname;
            LNameStdBox.Text = thisStudent.Lname;
            ContactStdBox.Text = thisStudent.ContactNo;
            DepStdBox.Text = thisStudent.Department;
            QualificationStdBox.Text = thisStudent.Qualification;
            bloodBoxStd.Text = thisStudent.BloodGroup;
            AdressStdBox.Text = thisStudent.Address;
            genderBox.Text = thisStudent.Gender;
        }
        public DataTable LoadStudentAttendance(string roll, string date)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Name");
            dt.Columns.Add("PRESENT?", typeof(bool));
            for (int i = 0; i < thisStudent.Course.Length; i++)
            {
                
                    if (thisStudent.Course[i].CourseName == courseBoxAtnd.SelectedItem.ToString())
                    {
                        DataRow row = dt.NewRow();
                        row["Roll No"] = thisStudent.RollNo;
                        row["Name"] = thisStudent.Fname + " " + thisStudent.Lname;
                        for (int j = 0; j < thisStudent.Course[i].attendance.Count; ++j)
                            if (thisStudent.Course[i].attendance[j].Date == date)
                                row["PRESENT?"] = thisStudent.Course[i].attendance[j].Status;
                        dt.Rows.Add(row);
                    }
               

            }

            return dt;
        }
        public DataTable LoadStudentMarks()
        {

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

            // Create a DataTable to store the student data


            for (int i = 0; i < thisStudent.Course.Length; i++)
            {
                if (thisStudent.Course[i].CourseName == courseBoxMarks.SelectedItem.ToString())
                {
                    DataRow row = dt.NewRow();
                    row["Roll No"] = thisStudent.RollNo;
                    row["Quiz 1"] = thisStudent.Course[i].marks.Quiz[0].ToString();
                    row["Quiz 2"] = thisStudent.Course[i].marks.Quiz[1].ToString();
                    row["Quiz 3"] = thisStudent.Course[i].marks.Quiz[2].ToString();
                    row["Quiz 4"] = thisStudent.Course[i].marks.Quiz[3].ToString();

                    row["Assignment 1"] = thisStudent.Course[i].marks.Assignment[0].ToString();
                    row["Assignment 2"] = thisStudent.Course[i].marks.Assignment[1].ToString();
                    row["Assignment 3"] = thisStudent.Course[i].marks.Assignment[2].ToString();

                    row["Mid 1"] = thisStudent.Course[i].marks.Mid[0].ToString();
                    row["Mid 2"] = thisStudent.Course[i].marks.Mid[1].ToString();

                    row["Final"] = thisStudent.Course[i].marks.final.ToString();

                    dt.Rows.Add(row);
                }
            }

            return dt;
        }
        public DataTable LoadStudentGrades()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Course");
            dt.Columns.Add("Grade");
            // Create a DataTable to store the student data


            for (int i = 0; i < thisStudent.Course.Length; i++)
            {
                //if (thisStudent.Course[i].CourseName == courseBoxGrades.Text)
                {
                    DataRow row = dt.NewRow();
                    row["Course"] = thisStudent.Course[i].CourseName.ToString();
                    row["Grade"] = thisStudent.Course[i].Grade;
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
        public DataTable LoadStudentCourses()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Serial");
            dt.Columns.Add("Name");
            // Create a DataTable to store the student data


            for (int i = 0; i < thisStudent.Course.Length; i++)
            {
                //if (thisStudent.Course[i].CourseName == courseBoxGrades.Text)
                {
                    DataRow row = dt.NewRow();

                    row["Serial"] = i + 1;
                    row["Name"] = thisStudent.Course[i].CourseName.ToString();
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
        public void setCourseBox()
        {
            for (int i = 0; i < thisStudent.Course.Length; ++i)
            {
                courseBoxAtnd.Items.Add(thisStudent.Course[i].CourseName);
                courseBoxMarks.Items.Add(thisStudent.Course[i].CourseName);
            }
        }
        private void studentForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.Enter;
            this.Close();
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
        private void studentForm_Load(object sender, EventArgs e)
        {
            loadHomePage();
            setCourseBox();
            gradeGrid.DataSource = LoadStudentGrades();
            courseGrid.DataSource = LoadStudentCourses();
            if (thisStudent.FeeStatus)
            {
                paidOrUnpaidLbl.Text = "Paid";
                paidOrUnpaidLbl.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                paidOrUnpaidLbl.Text = "Unpaid";
                paidOrUnpaidLbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void courseBoxAtnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendanceGrid.DataSource = LoadStudentAttendance(thisStudent.RollNo, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            attendanceGrid.DataSource = LoadStudentAttendance(thisStudent.RollNo, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
        }

        private void courseBoxMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            marksGrid.DataSource = LoadStudentMarks();
        }

        private void genderBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
