namespace MVC.Domain
{
    public class Product
    {
        public Product()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}