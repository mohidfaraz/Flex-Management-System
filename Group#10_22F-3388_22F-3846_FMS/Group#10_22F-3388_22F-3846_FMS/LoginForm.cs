using StudentManagementSystem;
using static adminFile.admin;


namespace Group_10_22F_3388_22F_3846_FMS
{
    public partial class LoginForm : Form
    {
        string path = "C:\\Users\\Lap_Tech\\Desktop\\OOP\\Group#10_22F-3388_22F-3846_FMS\\Group#10_22F-3388_22F-3846_FMS\\data\\login.txt";


        public static int loginType = 1;
        public static bool VerifyLogin(SysLogin user, string filepath)
        {
            string[] lines = File.ReadAllLines(@filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts[0] == user.UserName && parts[1] == user.Password)
                {
                    loginType = int.Parse(parts[2]);
                    return true;

                }
            }
            return false;
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)

        {
            SysLogin user = new SysLogin();
            user.UserName = userbox.Text;
            user.Password = passbox.Text;


            if (VerifyLogin(user, path))
            {

                if (loginType == 1)
                {
                    adminForm admin = new adminForm();
                    this.Hide();
                    admin.Show();

                }

                else if (loginType == 2)
                {
                    List<Student> Students = ReadJsonFile<Student>(Studentpath);
                    Student Student = Students.FirstOrDefault(s => s.RollNo == user.UserName);
                    studentForm std = new studentForm(Student);
                    this.Hide();
                    std.Show();
                }
                else if (loginType == 3)
                {
                    //teacher module
                    List<Teacher> teachers = ReadJsonFile<Teacher>(Teacherpath);
                    Teacher teacher = teachers.FirstOrDefault(t => t.tid == user.UserName);
                    teacherForm std = new teacherForm(teacher);
                    this.Hide();
                    std.Show();
                }

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Error");
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
        }
        static int i = 0;
        private void showpassword_Click(object sender, EventArgs e)
        {
            passbox.PasswordChar = '\0';

            if (i == 0)
            {
                passbox.PasswordChar = '*';
                i = 1;
            }
            else
            {
                passbox.PasswordChar = '\0';
                i = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}