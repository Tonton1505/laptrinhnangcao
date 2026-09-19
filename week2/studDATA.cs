using System.Collections.Generic;
using ExampleCAdvance.Entities;

namespace ExampleCAdvance
{
    public static class StudentData
    {
        public static List<Student> GetSampleStudents()
        {
            return new List<Student>
            {
                new Student { StuID = "SV001", Name = "Nguyen Van A", MidPoint = 8.0, FinalPoint = 9.0, Email = "a.nguyen@example.com" },
                new Student { StuID = "SV002", Name = "Tran Thi B",  MidPoint = 7.5, FinalPoint = 8.5, Email = "b.tran@example.com" },
                new Student { StuID = "SV003", Name = "Le Van C",    MidPoint = 6.0, FinalPoint = 7.0, Email = "c.le@example.com" },
                new Student { StuID = "SV004", Name = "Pham Thi D",  MidPoint = 9.0, FinalPoint = 9.5, Email = "d.pham@example.com" },
                new Student { StuID = "SV005", Name = "Hoang Van E",  MidPoint = 5.5, FinalPoint = 6.5, Email = "e.hoang@example.com" }
            };
        }
    }
}
