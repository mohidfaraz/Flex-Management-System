using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static adminFile.admin;



namespace StudentManagementSystem
{
    public class SysLogin
    {
        protected string userName { set; get; }
        protected string password { set; get; }

        public string UserName   // property
        {
            get { return userName; }   // get method
            set { userName = value; }  // set method
        }
        public string Password   // property
        {
            get { return password; }   // get method
            set { password = value; }  // set method
        }
        public SysLogin()
        {
            userName = "user";
            password = "password";
        }
    }
    public abstract class Person : SysLogin //// abstract class , polymorphism done.
    {
        public Person()
        {
            fName = string.Empty;
            lName = string.Empty;
            gender = string.Empty;
            contactNo = string.Empty;
            qualification = string.Empty;
            address = string.Empty;
            bloodGroup = string.Empty;

        }

        protected string fName { set; get; }
        protected string lName { set; get; }
        protected string gender { set; get; }
        protected string contactNo { set; get; }
        protected string qualification { set; get; }
        protected string bloodGroup { set; get; }
        protected string address { set; get; }

        public virtual string Fname   // property
        {
            get { return fName; }   // get method
            set { fName = value; }  // set method
        }

        public virtual string Lname //////////////////////// used virtual so that i may override them in future,
        {
            set { lName = value; }
            get { return lName; }
        }

        public virtual string Gender   // property
        {
            get { return gender; }   // get method
            set { gender = value; }  // set method
        }


        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        public string Qualification   // property
        {
            get { return qualification; }   // get method
            set { qualification = value; }  // set method
        }
        public string BloodGroup
        {
            get { return bloodGroup; }
            set { bloodGroup = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }

    public class Marks
    {

        protected double[] quiz { set; get; } = new double[10];
        protected float[] assignment { set; get; } = new float[5];
        protected float[] mid { set; get; } = new float[2];
        protected float finalExam { set; get; }
        protected float total { set; get; }
        protected static int totQuiz { set; get; }
        protected static int totAssignment { set; get; }
        public Marks()
        {

        }

        public double[] Quiz
        {
            get { return quiz; }
            set { quiz = value; }
        }
        public float[] Assignment
        {
            get { return assignment; }
            set { assignment = value; }
        }
        public float[] Mid
        {
            set { mid = value; }
            get { return mid; }
        }
        public float final
        {
            set { finalExam = value; }
            get { return finalExam; }
        }
        public int TotQuiz
        {
            get { return totQuiz; }
            set { totQuiz = value; }
        }
        public int TotAssignment
        {
            get { return totAssignment; }
            set { totAssignment = value; }
        }
    }
    public class Attendance
    {
        protected string date { set; get; }
        protected bool status { set; get; }
        public Attendance()
        {
            date = String.Empty;
            status = false;
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

    }
    public class Course
    {
        protected string courseName { set; get; }
        protected string teacherId { set; get; }
        protected string grade { set; get; }
        public Marks marks = new Marks();

        public List<Attendance> attendance { set; get; }
        public Course()
        {
            courseName = string.Empty;
            attendance = new List<Attendance> { };
            grade = "I";
        }
        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public string Grade
        {
            set { grade = value; }
            get { return grade; }
        }
       
        public string TeacherId
        {
            set { teacherId = value; }
            get { return teacherId; }
        }



    }

    public class Student : Person
    {

        private string rollNo { set; get; }
        private float gpa { set; get; }
        private string section { set; get; }
        private string department { set; get; }
        private Course[] course { set; get; }
        private bool feeStatus { set; get; }
        private string regDate { set; get; }
        public Student()
        {
            rollNo = section = department = string.Empty;
            gpa = 0;
            regDate = "01-01-2000";
            feeStatus = false;

        }



        //getters and setters

        public string RollNo  // property
        {
            get { return rollNo; }   // get method
            set { rollNo = value; }  // set method
        }
        public float Gpa
        { get { return gpa; } set { gpa = value; } }
        public string Section
        { get { return section; } set { section = value; } }
        public string Department
        { get { return department; } set { department = value; } }
        public Course[] Course
        { get { return course; } set { course = value; } }
        public bool FeeStatus
        { get { return feeStatus; } set { feeStatus = value; } }
        public string RegDate
        { get { return regDate; } set { regDate = value; } }
    
    }

    public class Teacher : Person
    {
        private string department { set; get; }
        private string tId { set; get; }
        private string course { set; get; }
        private string regDate { set; get; }
        private long salary { set; get; }
        public Teacher()
        {
            department = string.Empty;
            course = string.Empty;
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string tid
        {
            get { return tId; }
            set { tId = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public string RegDate
        {
            get { return regDate; }
            set { regDate = value; }
        }
        public long Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        //RETURNS DATATABLE ON BASIS OF DEPARTMENT NAME OF TEACHER
        public static DataTable ShowTimetable(string depName)
        {
            DataTable dataTable = new DataTable();
            using (TextFieldParser parser = new TextFieldParser(timetablePath + depName + ".csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                // FIRST ROW CONTAINS THE NAME OF FIELDS SO WE MAKE COLUMNS BASED ON IT
                if (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        dataTable.Columns.Add(fields[i]);
                    }
                }
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    dataTable.Rows.Add(fields);
                }
            }
            return dataTable;
        }
    }


    public class Administrator : Person
    {
        public Administrator() { }

    }


}