namespace JWT.Core.Domain
{
    public class Category
    {
        public int Id { get; set; }

        public string? Defination { get; set; }

        public List<Product> products { get; set; }

        public Category()
        {
            products= new List<Product>();
        }

    }
}
