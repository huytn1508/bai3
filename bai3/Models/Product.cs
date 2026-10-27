namespace bai3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        // Foreign key to Category
        public int CategoryId { get; set; }
        // navigation property to Category
        public Category? Category { get; set; }
    }
}
