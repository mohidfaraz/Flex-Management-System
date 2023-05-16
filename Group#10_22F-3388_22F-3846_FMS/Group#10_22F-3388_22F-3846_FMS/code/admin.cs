using Newtonsoft.Json;
using StudentManagementSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;
using System.Windows.Forms;
using Group_10_22F_3388_22F_3846_FMS;

namespace adminFile
{
    public class writer
    {
        public static string path;

        public static int operator +(writer s, string[] data)// operator overloading for writing to file
        {
            admin.writeToTxt(data, path);
            return 0;
        }
    }

    public class admin
    {
        public static string Studentpath = "C:\\Users\\Lap_Tech\\Desktop\\OOP\\Group#10_22F-3388_22F-3846_FMS\\Group#10_22F-3388_22F-3846_FMS\\data\\students.json";
        public static string Teacherpath = "C:\\Users\\Lap_Tech\\Desktop\\OOP\\Group#10_22F-3388_22F-3846_FMS\\Group#10_22F-3388_22F-3846_FMS\\data\\teachers.json";
        public static string pathLogin = ("C:\\Users\\Lap_Tech\\Desktop\\OOP\\Group#10_22F-3388_22F-3846_FMS\\Group#10_22F-3388_22F-3846_FMS\\data\\login.txt");
        public static string timetablePath = "C:\\Users\\Lap_Tech\\Desktop\\OOP\\Group#10_22F-3388_22F-3846_FMS\\Group#10_22F-3388_22F-3846_FMS\\data\\TimeTables\\";
        public static void writeToTxt(string[] data, string path)
        {
            using (StreamWriter writer = new StreamWriter(@path, true)) //true to append data to the file
            {
                writer.WriteLine(string.Join(",", data));
            }
        }
        public static List<T> ReadJsonFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found", "ERROR");
                Environment.Exit(0);
            }

            string fileContents = File.ReadAllText(filePath);
            List<T> deserializedObjects = JsonConvert.DeserializeObject<List<T>>(fileContents);

            return deserializedObjects;
        }

        public static void WriteJsonFile<T>(List<T> data, string filePath)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, json);
        }

        public static Student getSpecificStudent(string roll)
        {
            List<Student> students = ReadJsonFile<Student>(Studentpath);

            Student student = students.FirstOrDefault(s => s.RollNo == roll.ToUpper());
            return student;
        }
        public static Teacher getSpecificTeacher(string TID)
        {
            List<Teacher> Teachers = ReadJsonFile<Teacher>(Teacherpath);

            Teacher Teacher = Teachers.FirstOrDefault(s => s.tid == TID.ToUpper());
            return Teacher;
        }


    }
}
