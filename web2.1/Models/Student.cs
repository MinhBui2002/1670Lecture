namespace web2._1.Models
{
    public class Student
    {
        public int Id { get; set; } // Primary key, auto-increment
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public float Grade { get; set; }
        public bool IsGraduated { get; set; }
        public string Image { get; set; }
    }
}
