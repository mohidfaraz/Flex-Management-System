using adminFile;
using Newtonsoft.Json;
using StudentManagementSystem;
using System.Data;
using static adminFile.admin;

namespace Group_10_22F_3388_22F_3846_FMS
{
    public partial class adminForm : Form
    {


        public adminForm()
        {
            InitializeComponent();
            writer write = new writer();
            writer.path = pathLogin;

        }
        #region STUDENT
        //GENERATE ROLL NUMBER
        public string RollNoGenerator(List<Student> students)
        {
            string rollNo = "";
            string dep = deptBox.SelectedItem.ToString();

            int last = 1;
            //count students of same department
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].Department == dep)
                {
                    last++;
                }
            }
            //generate roll number
            if (dep == "Computer")
            {
                rollNo = "CS-" + last.ToString("D4");
            }
            else if (dep == "Electric")
            {
                rollNo = "EE-" + last.ToString("D4");
            }
            else if (dep == "Software")
            {
                rollNo = "SE-" + last.ToString("D4");
            }
            else if (dep == "BBA")
            {
                rollNo = "B-" + last.ToString("D4");
            }
            else if (dep == "Social Sciences")
            {
                rollNo = "SS-" + last.ToString("D4");
            }
            return rollNo;

        }
        public DataTable LoadStudents()
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
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Contact No");
            dt.Columns.Add("Address");
            dt.Columns.Add("Qualification");
            dt.Columns.Add("Department");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Blood Group");
            dt.Columns.Add("Fee Status");
            dt.Columns.Add("Reg Date");
            // Add each student's data to the DataTable
            if (students == null)
            {

            }
            else
                foreach (Student student in students)
                {
                    DataRow row = dt.NewRow();
                    row["First Name"] = student.Fname;
                    row["Last Name"] = student.Lname;
                    row["Roll No"] = student.RollNo;
                    row["Contact No"] = student.ContactNo;
                    row["Address"] = student.Address;
                    row["Qualification"] = student.Qualification;
                    row["Department"] = student.Department;
                    row["Gender"] = student.Gender;
                    row["Blood Group"] = student.BloodGroup;
                    row["Fee Status"] = student.FeeStatus ? "Paid" : "Unpaid";
                    row["Reg Date"] = student.RegDate;
                    dt.Rows.Add(row);
                }

            return dt;
        }

        public DataTable LoadStudents(string key)
        {


            // Read the student data from the JSON file
            string fileContents = System.IO.File.ReadAllText(Studentpath);
            if (fileContents == string.Empty)
            {
                MessageBox.Show("File not found", "ERROR");
                logout();
            }
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(fileContents);
            int count = 0;
            // Create a DataTable to store the student data
            DataTable dt = new DataTable();
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Roll No");
            dt.Columns.Add("Contact No");
            dt.Columns.Add("Address");
            dt.Columns.Add("Qualification");
            dt.Columns.Add("Department");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Blood Group");
            dt.Columns.Add("Fee Status");
            dt.Columns.Add("Reg Date");
            // Add each student's data to the DataTable
            foreach (Student student in students)
            {
                if (student.Department == key || student.RollNo == key)
                {
                    DataRow row = dt.NewRow();
                    row["First Name"] = student.Fname;
                    row["Last Name"] = student.Lname;
                    row["Roll No"] = student.RollNo;
                    row["Contact No"] = student.ContactNo;
                    row["Address"] = student.Address;
                    row["Qualification"] = student.Qualification;
                    row["Department"] = student.Department;
                    row["Gender"] = student.Gender;
                    row["Blood Group"] = student.BloodGroup;
                    row["Fee Status"] = student.FeeStatus ? "Paid" : "Unpaid";
                    row["Reg Date"] = student.RegDate;
                    dt.Rows.Add(row);
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("No Student Found", "ERROR");
            }

            return dt;
        }
        public List<Course> setCoursesFn()
        {
            List<Course> courses = new List<Course>();

            foreach (var item in courseBox.CheckedItems)
            {
                if (!item.Equals(string.Empty))
                {
                    Course course = new Course();
                    course.CourseName = item.ToString();
                    courses.Add(course);
                }

            }

            return courses;
        }
        public void addStudentFn()
        {




            List<Student> deserializedStudent = ReadJsonFile<Student>(Studentpath);
            Student s1 = new Student();
            s1.Course = setCoursesFn().ToArray();
            bool flag = false;
            if (firstNameBox.Text.Equals(string.Empty) || (lastNameBox.Text.Equals(string.Empty))
                || contactBox.Text.Equals(string.Empty) || addressBox.Text.Equals(string.Empty))
                flag = true;
            if (!flag)
            {
                if (deserializedStudent == null)
                {
                    deserializedStudent = new List<Student>();
                }
                try
                {
                    s1.Fname = firstNameBox.Text.ToString();
                    s1.Lname = lastNameBox.Text.ToString();
                    s1.ContactNo = contactBox.Text.ToString();
                    s1.Address = addressBox.Text.ToString();
                    s1.Qualification = QualificationBox.SelectedItem.ToString();
                    s1.Department = deptBox.SelectedItem.ToString();
                    s1.Gender = genderBox.SelectedItem.ToString();
                    s1.BloodGroup = bloodGroupBox.SelectedItem.ToString();
                    s1.FeeStatus = paidButton.Checked;
                    s1.RollNo = RollNoGenerator(deserializedStudent);
                    s1.RegDate = DateTime.Now.ToString("dd/MM/yyyy");
                    s1.UserName = s1.RollNo;
                    s1.Password = s1.RollNo;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Exception Occured");
                }
                writer write = new writer();
                writer.path = pathLogin;
                string[] data = new string[3];
                data[0] = s1.UserName;
                data[1] = s1.Password;
                data[2] = "2";
                int n = write + data; ////////same as write to txt but with operator overloading
                deserializedStudent.Add(s1);
                WriteJsonFile<Student>(deserializedStudent, Studentpath);
                string fileContents1 = System.IO.File.ReadAllText(Studentpath);
                Student[] deserializedStudent1 = JsonConvert.DeserializeObject<Student[]>(fileContents1);
                MessageBox.Show("Student Added Successfully", "Success");

            }
            else
            {
                MessageBox.Show("Make sure there is no box left empty", "Error");
            }
        }
        public void editStudentFn()
        {
            List<Student> students = ReadJsonFile<Student>(Studentpath);

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].RollNo == rollBoxEdit.Text.ToUpper())
                {
                    students[i].Fname = firstNameBoxEdit.Text.ToString();
                    students[i].Lname = lastNameBoxEdit.Text.ToString();
                    students[i].ContactNo = contactBoxEdit.Text.ToString();
                    students[i].Address = addressBoxEdit.Text.ToString();
                    students[i].FeeStatus = paidBtnEdit.Checked;
                    break;
                }

            }
            WriteJsonFile<Student>(students, Studentpath);
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            addStudentFn();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (viewStdBox.SelectedIndex == 0)
            {
                studentGrid.DataSource = LoadStudents();
            }
            else if (viewStdBox.SelectedIndex == 1)
            {
                studentGrid.DataSource = LoadStudents(deptInViewBox.SelectedItem.ToString());
            }
            else if (viewStdBox.SelectedIndex == 2)
            {
                studentGrid.DataSource = LoadStudents(rollNoInViewBox.Text.ToUpper());
            }
        }

        private void viewStdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewStdBox.SelectedIndex == 0)
            {
                viewByDept.Visible = false;
                viewByRollPnl.Visible = false;
            }
            else if (viewStdBox.SelectedIndex == 1)
            {
                viewByDept.Visible = true;
                viewByRollPnl.Visible = false;
            }
            else if (viewStdBox.SelectedIndex == 2)
            {
                viewByRollPnl.Visible = true;
                viewByDept.Visible = false;
            }
        }

        private void enterBtnEdit_Click(object sender, EventArgs e)
        {

            List<Student> students = ReadJsonFile<Student>(Studentpath);
            Student student = students.FirstOrDefault(s => s.RollNo == rollBoxEdit.Text.ToUpper());
            if (!rollBoxEdit.Text.Equals(string.Empty))
            {
                if (student != null)
                {
                    firstNameBoxEdit.Text = student.Fname;
                    lastNameBoxEdit.Text = student.Lname;
                    contactBoxEdit.Text = student.ContactNo;
                    addressBoxEdit.Text = student.Address;
                    if (student.FeeStatus)
                        paidBtnEdit.Checked = true;
                    else
                        unPaidEdit.Checked = true;
                }
                else
                {
                    MessageBox.Show("Student not found!", "Ohno!");
                }
            }
            else
            {
                MessageBox.Show("Please enter Roll# first!", "Ohno!");
            }
        }

        private void updateBtnEdit_Click(object sender, EventArgs e)
        {
            editStudentFn();
            MessageBox.Show("Student edited Succesfully!", "Student edited");
        }
        #endregion
        #region TEACHER
        public string TidGenerator(List<Teacher> teachers)
        {
            string Tid = "";
            string dep = deptBoxTch.SelectedItem.ToString();


            int last = 1;
            //count students of same department
            for (int i = 0; i < teachers.Count(); i++)
            {
                if (teachers[i].Department == dep)
                {
                    last++;
                }
            }
            //generate roll number
            if (dep == "Computer")
            {
                Tid = "CST-" + last.ToString("D3");
            }
            else if (dep == "Electric")
            {
                Tid = "EET-" + last.ToString("D3");
            }
            else if (dep == "Software")
            {
                Tid = "SET-" + last.ToString("D3");
            }
            else if (dep == "BBA")
            {
                Tid = "BT-" + last.ToString("D3");
            }
            else if (dep == "Social Sciences")
            {
                Tid = "SST-" + last.ToString("D3");
            }
            return Tid;

        }

        public void addTeacherFn()
        {

            List<Teacher> deserializedTeacher = ReadJsonFile<Teacher>(Teacherpath);
            Teacher t1 = new Teacher();


            bool flag = false;
            if (string.IsNullOrEmpty(fNameBoxTch.Text) || (string.IsNullOrEmpty(LNameBoxTch.Text))
                || string.IsNullOrEmpty(contactBoxTch.Text) || (string.IsNullOrEmpty(addressBoxTch.Text)))
                flag = true;
            if (!flag)
            {
                if (deserializedTeacher == null)
                {
                    deserializedTeacher = new List<Teacher>();
                }
                t1.Fname = fNameBoxTch.Text.ToString();
                t1.Lname = LNameBoxTch.Text.ToString();
                t1.ContactNo = contactBoxTch.Text.ToString();
                t1.Address = addressBoxTch.Text.ToString();
                t1.Qualification = qualificationBoxTch.SelectedItem.ToString();
                t1.Department = deptBoxTch.SelectedItem.ToString();
                t1.Gender = genderBoxTch.SelectedItem.ToString();
                t1.Salary = Convert.ToInt64(salaryBoxTch.Text);
                t1.tid = TidGenerator(deserializedTeacher);
                t1.RegDate = DateTime.Now.ToString("dd/MM/yyyy");
                t1.Course = courseBoxTch.Text;
                t1.UserName = t1.tid;
                t1.Password = t1.tid;
                string[] data = new string[3];
                data[0] = t1.UserName;
                data[1] = t1.Password;
                data[2] = "3";


                writeToTxt(data, pathLogin);
                deserializedTeacher.Add(t1);
                WriteJsonFile<Teacher>(deserializedTeacher, Teacherpath);
                string fileContents1 = System.IO.File.ReadAllText(Teacherpath);
                Teacher[] deserializedTeacher1 = JsonConvert.DeserializeObject<Teacher[]>(fileContents1);

                MessageBox.Show("Teacher added successfully", "Success!");
            }
            else
            {
                MessageBox.Show("Make sure there is no box left empty", "OHNO!");
            }
        }

        public void editTeacherFn()
        {
            List<Teacher> teachers = ReadJsonFile<Teacher>(Teacherpath);


            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i].tid == tidBoxEdit.Text.ToUpper())
                {
                    teachers[i].Qualification = qualificationBoxTchEdit.Text;
                    teachers[i].ContactNo = contactBoxEditTch.Text.ToString();
                    teachers[i].Address = addressBoxEditTch.Text.ToString();
                    teachers[i].Salary = Convert.ToInt32(salaryBoxEdit.Text);
                    break;
                }

            }
            MessageBox.Show("Teacher updated succesfully!", "Teacher Updated");
            WriteJsonFile<Teacher>(teachers, Teacherpath);
        }
        private void enterBtnEditTch_Click(object sender, EventArgs e)
        {
            string tid = tidBoxEdit.Text.ToUpper();
            List<Teacher> teachers = ReadJsonFile<Teacher>(Teacherpath);
            Teacher teacher = teachers.FirstOrDefault(t => t.tid == tid);
            if (teacher == null)
            {
                MessageBox.Show("No Teachers Found!", "Ohno!");
            }
            else
            {
                salaryBoxEdit.Text = teacher.Salary.ToString();
                qualificationBoxTchEdit.Text = teacher.Qualification.ToString();
                contactBoxEditTch.Text = teacher.ContactNo.ToString();
                addressBoxEditTch.Text = teacher.Address;
            }
        }
        private void updateBtnTchEdit_Click(object sender, EventArgs e)
        {
            string tid = tidBoxEdit.Text.ToUpper();
            editTeacherFn();
        }
        public DataTable LoadTeachers()
        {
            // Read the teacher data from the JSON file
            string fileContents = System.IO.File.ReadAllText(@Teacherpath);
            if (fileContents == string.Empty)
            {
                MessageBox.Show("File not found", "ERROR");
            }
            List<Teacher> teachers = JsonConvert.DeserializeObject<List<Teacher>>(fileContents);

            // Create a DataTable to store the teacher data
            DataTable dt = new DataTable();
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("TID");
            dt.Columns.Add("Contact No");
            dt.Columns.Add("Address");
            dt.Columns.Add("Qualification");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Reg Date");
            // Add each teacher's data to the DataTable
            if (teachers == null)
            {

            }
            else
                foreach (Teacher teacher in teachers)
                {
                    DataRow row = dt.NewRow();
                    row["First Name"] = teacher.Fname;
                    row["Last Name"] = teacher.Lname;
                    row["TID"] = teacher.tid;
                    row["Contact No"] = teacher.ContactNo;
                    row["Address"] = teacher.Address;
                    row["Qualification"] = teacher.Qualification;
                    row["Gender"] = teacher.Gender;
                    row["Salary"] = teacher.Salary;
                    row["Reg Date"] = teacher.RegDate;
                    dt.Rows.Add(row);
                }


            return dt;
        }
        public void setComboBoxes()
        {
            genderBox.SelectedIndex = 0;
            genderBoxTch.SelectedIndex = 0;
            deptBox.SelectedIndex = 0;
            deptBoxTch.SelectedIndex = 0;
            deptInViewBox.SelectedIndex = 0;
            qualificationBoxTch.SelectedIndex = 0;
            QualificationBox.SelectedIndex = 0;
            courseBox.SelectedIndex = 0;
            courseBoxTch.SelectedIndex = 0;
            bloodGroupBox.SelectedIndex = 0;
            UnpaidBtn.Checked = true;
        }
        private void addBtnTch_Click(object sender, EventArgs e)
        {
            addTeacherFn();
        }
        #endregion

        private void adminForm_Load(object sender, EventArgs e)
        {
            teacherGrid.DataSource = LoadTeachers();
            setComboBoxes();
        }

        public void logout()
        {
            this.Close();
            LoginForm loginForm1 = new LoginForm();
            loginForm1.Show();
        }
        private void logOutImage_Click(object sender, EventArgs e)
        {

        }
        private void adminTAB_Click(object sender, EventArgs e)
        {
            teacherGrid.DataSource = LoadTeachers();
        }

        private void logoutLBl_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void genderLbl_Click(object sender, EventArgs e)
        {

        }
    }

}
