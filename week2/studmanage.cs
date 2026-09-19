using System;
using System.Collections.Generic;
using System.Linq;
using ExampleCAdvance.Entities;

namespace ExampleCAdvance
{
    public class StudentManager
    {
        private List<Student> students;

        public StudentManager(List<Student> students)
        {
            this.students = students;
        }

        public void RemoveStudent(string stuId)
        {
            Student student = GetStudentById(stuId);
            if (student == null)
            {
                Console.WriteLine($"Khong tim thay sinh vien co ID: {stuId}");
                return;
            }
            students.Remove(student);
            Console.WriteLine($"Da xoa sinh vien: {student.Name}");
        }

        public void UpdateStudent(string stuId, string name, double midPoint, double finalPoint, string email)
        {
            Student student = GetStudentById(stuId);
            if (student == null)
            {
                Console.WriteLine($"Khong tim thay sinh vien co ID: {stuId}");
                return;
            }

            student.Name = name;
            student.MidPoint = midPoint;
            student.FinalPoint = finalPoint;
            student.Email = email;

            Console.WriteLine($"Da cap nhat sinh vien: {student.StuID}");
        }

        public Student GetStudentById(string stuId)
        {
            return students.FirstOrDefault(s => s.StuID == stuId);
        }

        public List<Student> GetStudentByName(string name)
        {
            return students
                .Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Student> GetStudentsPassed(double passCondition)
        {
            return students
                .Where(s => ((s.MidPoint + s.FinalPoint) / 2) >= passCondition)
                .ToList();
        }
    }
}
