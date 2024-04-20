namespace PustokMVC.Models
{
    public class Basket
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
       
        public AppUser AppUser { get; set; }

    }
}
