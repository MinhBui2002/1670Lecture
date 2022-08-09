namespace web11.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // Many to One
        public int BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
