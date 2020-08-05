namespace API.Model
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Seller Seller { get; set; }
    }
}