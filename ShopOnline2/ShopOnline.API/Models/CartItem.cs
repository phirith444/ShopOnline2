namespace ShopOnline.API.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; } //used as a FK to join the cart model - one to many relationship
        public int ProductId { get; set; }
        public int Qty { get; set; }

    }
}
