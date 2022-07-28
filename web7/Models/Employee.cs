namespace web7.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public float Salary { get; set; }

        public Employee(string name, int age, string email, string address, string gender, float salary)
        {
            Name = name;
            Age = age;
            Email = email;
            Address = address;
            Gender = gender;
            Salary = salary;
        }

    }
}
