namespace ShopOnline.API.Models
{
    public class User //Has one to one relationship with the Cart Model
    {
        public int Id { get; set; }
        public string UserName { get; set; }
            
    }
}
