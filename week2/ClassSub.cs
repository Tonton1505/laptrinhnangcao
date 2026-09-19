using System.Collections.Generic;

namespace ConsoleApp
{
    public class ClassSubject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Semester { get; set; }
        public string Teacher { get; set; }
        public List<Student> Students { get; set; }

        public ClassSubject()
        {
            Students = new List<Student>();
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Semester: {Semester}, Teacher: {Teacher}";
        }
    }
}
