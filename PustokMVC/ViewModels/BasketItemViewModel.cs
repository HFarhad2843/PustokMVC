using PustokMVC.Models;

namespace PustokMVC.ViewModels
{
    public class BasketItemViewModel
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int Count { get; set; }
    }
}
