namespace ShopOnline.API.Models
{
    public class ProductCategory //One to many relationship with Product model
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
