using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business_Logic
{
    public static class Logic
    {
        public static List<Student> students { get; set; } = new List<Student>()
        {
            new Student("Alisher", "ISIT", "KI21-12B") ,
            new Student("Suiun", "ISIT", "KI21-14"),
            new Student("Suiun", "ISIT", "KI21-14"),
            new Student("Gatz", "PI", "KI21-03"),
            new Student("Gatz", "PI", "KI21-03"),
            new Student("Gatz", "PI", "KI21-03"),
            new Student("Gatz", "PI", "KI21-03"),
            new Student("Gatz", "LI", "KI21-03"),
        };

        public static void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student(name, speciality, group));
        }
        public static void DeleteStudent(int id)
        {
            students.RemoveAt(id);
        }
        public static List<string[]> GetAll() 
        { 
            return students.Select(s => new string[] {s.Name, s.Speciality, s.Group }).ToList();        
        }
    }
}
