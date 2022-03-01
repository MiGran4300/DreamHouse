using System.ComponentModel;

namespace DreamHouse.Models
{
    public class Offer
    {
        public int OfferId { get; set; }
        public int BuildingId { get; set; }
        [DisplayName("Тип на имота")]
        public string? Type { get; set; }
        [DisplayName("Площ (кв.м)")]
        public int? Size { get; set; }
        [DisplayName("Брой стаи")]
        public int? Rooms { get; set; }
        [DisplayName("Статус")]
        public string? State { get; set; }
        [DisplayName("Скица")]
        public string? Scheme { get; set; }

        public Building? Building { get; set; }

        
    }
}
