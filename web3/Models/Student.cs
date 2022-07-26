namespace web3.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Student(int Id, string Name, int Age, string PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
        }
        

    }
}
