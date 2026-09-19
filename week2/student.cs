namespace ConsoleApp
{
    public class Student
    {
        public int StdID { get; set; }
        public string Name { get; set; }
        public double MidPoint { get; set; }
        public double FinalPoint { get; set; }

        public override string ToString()
        {
            return $"ID: {StdID}, Name: {Name}, Midpoint: {MidPoint}, Final: {FinalPoint}";
        }
    }
}
