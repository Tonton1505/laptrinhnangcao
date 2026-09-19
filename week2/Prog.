using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var csharpClass = new ClassSubject
            {
                Id = 1,
                Name = "C# Programming",
                Semester = "Spring 2024",
                Teacher = "Mr. John",
                Students = new List<Student>
                {
                    new Student { StdID = 1, Name = "Alice", MidPoint = 8.5, FinalPoint = 9.0 },
                    new Student { StdID = 2, Name = "Bob", MidPoint = 7.0, FinalPoint = 7.5 },
                    new Student { StdID = 3, Name = "Charlie", MidPoint = 9.0, FinalPoint = 8.5 },
                    new Student { StdID = 4, Name = "David", MidPoint = 6.0, FinalPoint = 6.5 }
                }
            };

            var javaClass = new ClassSubject
            {
                Id = 2,
                Name = "Java Programming",
                Semester = "Spring 2024",
                Teacher = "Mr. Smith",
                Students = new List<Student>
                {
                    new Student { StdID = 5, Name = "Eve", MidPoint = 8.0, FinalPoint = 8.5 },
                    new Student { StdID = 6, Name = "Frank", MidPoint = 7.5, FinalPoint = 8.0 },
                    new Student { StdID = 7, Name = "Grace", MidPoint = 9.5, FinalPoint = 9.5 }
                }
            };

            var pythonClass = new ClassSubject
            {
                Id = 3,
                Name = "Python Programming",
                Semester = "Spring 2024",
                Teacher = "Ms. Brown",
                Students = new List<Student>
                {
                    new Student { StdID = 8, Name = "Henry", MidPoint = 7.0, FinalPoint = 7.5 },
                    new Student { StdID = 9, Name = "Ivy", MidPoint = 8.5, FinalPoint = 9.0 }
                }
            };

            var classes = new List<ClassSubject> { csharpClass, javaClass, pythonClass };

            Console.WriteLine("=========== THÔNG TIN LỚP HỌC ===========\n");
            DisplayAllClasses(classes);

            Console.WriteLine("\n=========== DANH SÁCH SINH VIÊN TRONG LỚP C# ===========\n");
            DisplayStudentsInClass(csharpClass);

            Console.WriteLine("\n=========== SINH VIÊN CÓ ĐIỂM TRUNG BÌNH >= 8.0 ===========\n");
            DisplayHighPerformingStudents(classes);

            Console.WriteLine("\n=========== SINH VIÊN THEO LỚP (CÓ ĐIỂM CUỐI >= 8.0) ===========\n");
            DisplayGroupedStudents(classes);

            Console.WriteLine("\n=========== TÍNH ĐIỂM TRUNG BÌNH LỚP ===========\n");
            DisplayClassAverages(classes);

            Console.WriteLine("\n=========== LỚP CÓ NHIỀU SINH VIÊN NHẤT ===========\n");
            DisplayClassWithMostStudents(classes);

            Console.WriteLine("\n=========== SẮP XẾP SINH VIÊN THEO ĐIỂM CUỐI (GIẢM DẦN) ===========\n");
            DisplayStudentsSortedByFinalPoint(csharpClass);
        }

        static void DisplayAllClasses(List<ClassSubject> classes)
        {
            foreach (var classSubject in classes)
            {
                Console.WriteLine(classSubject);
                Console.WriteLine($"Số lượng sinh viên: {classSubject.Students.Count}");
                Console.WriteLine("Sinh viên:");
                foreach (var student in classSubject.Students)
                {
                    Console.WriteLine($"  - {student}");
                }
                Console.WriteLine();
            }
        }

        static void DisplayStudentsInClass(ClassSubject classSubject)
        {
            Console.WriteLine($"Lớp: {classSubject.Name}\n");
            var students = classSubject.Students.OrderBy(s => s.Name);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void DisplayHighPerformingStudents(List<ClassSubject> classes)
        {
            var highPerformers = classes
                .SelectMany(c => c.Students)
                .Where(s => (s.MidPoint + s.FinalPoint) / 2 >= 8.0)
                .OrderByDescending(s => (s.MidPoint + s.FinalPoint) / 2);

            foreach (var student in highPerformers)
            {
                double average = (student.MidPoint + student.FinalPoint) / 2;
                Console.WriteLine($"{student.Name}: Trung bình = {average:F2}");
            }
        }

        static void DisplayGroupedStudents(List<ClassSubject> classes)
        {
            var groupedStudents = classes
                .Select(c => new
                {
                    ClassName = c.Name,
                    HighScorers = c.Students.Where(s => s.FinalPoint >= 8.0).ToList()
                });

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Lớp: {group.ClassName}");
                Console.WriteLine($"Sinh viên có điểm cuối >= 8.0:");
                foreach (var student in group.HighScorers)
                {
                    Console.WriteLine($"  - {student.Name}: {student.FinalPoint}");
                }
                Console.WriteLine();
            }
        }

        static void DisplayClassAverages(List<ClassSubject> classes)
        {
            var classAverages = classes.Select(c => new
            {
                ClassName = c.Name,
                Teacher = c.Teacher,
                AverageMid = c.Students.Average(s => s.MidPoint),
                AverageFinal = c.Students.Average(s => s.FinalPoint)
            });

            foreach (var classAvg in classAverages)
            {
                Console.WriteLine($"Lớp: {classAvg.ClassName}");
                Console.WriteLine($"  Giáo viên: {classAvg.Teacher}");
                Console.WriteLine($"  Trung bình điểm giữa kỳ: {classAvg.AverageMid:F2}");
                Console.WriteLine($"  Trung bình điểm cuối kỳ: {classAvg.AverageFinal:F2}");
                Console.WriteLine();
            }
        }

        static void DisplayClassWithMostStudents(List<ClassSubject> classes)
        {
            var classWithMost = classes
                .OrderByDescending(c => c.Students.Count)
                .First();

            Console.WriteLine($"Lớp: {classWithMost.Name}");
            Console.WriteLine($"Số lượng sinh viên: {classWithMost.Students.Count}");
        }

        static void DisplayStudentsSortedByFinalPoint(ClassSubject classSubject)
        {
            Console.WriteLine($"Lớp: {classSubject.Name}\n");
            var sortedStudents = classSubject.Students
                .OrderByDescending(s => s.FinalPoint)
                .ThenBy(s => s.Name);

            int rank = 1;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{rank}. {student.Name}: {student.FinalPoint}");
                rank++;
            }
        }
    }
}
