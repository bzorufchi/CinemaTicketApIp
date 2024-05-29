namespace CinemaTicket.Entities
{
    public class TicketEntities
    {
        public int Id { get; set; }
        public SitSansEntities SitSansId { get; set; }
        public SansEntities SansId { get; set; }
        public UserEntities UserId { get; set; }
        public TicketStatusEntities TicketStatusId { get; set; }
        public int SellPrice { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
    }
}
