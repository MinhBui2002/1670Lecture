namespace web5.Models
{
    public class Mobile
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Mobile(int number, string name, int quantity, double price)
        {
            Number = number;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
