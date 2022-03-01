using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DreamHouse.Models
{
    public class Building
    {
        public int BuildingId { get; set; }
        [Required]
        [DisplayName("Име на сградата")]
        public string? Name { get; set; }
        [Required]
        [DisplayName("Адрес")]
        public string? Address { get; set; }
        [DisplayName("Етаж")]
        public int? Floors { get; set; }
        [DisplayName("Асансьор")]
        public string? Elevator { get; set; }
        public ICollection<Offer>? Offers { get; set; }
        
    }
}
