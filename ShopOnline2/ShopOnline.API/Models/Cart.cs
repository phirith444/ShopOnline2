namespace ShopOnline.API.Models
{
    public class Cart //one to many relationship with the CartItem model 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
