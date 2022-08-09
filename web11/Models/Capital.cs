namespace web11.Models
{
    public class Capital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Area { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
