namespace CinemaTicket.Entities
{
    public class SitSansEntities
    {
        public int Id { get; set; }
        public SitEntities SitId { get; set; }
        public SansEntities SansId { get; set; }
        public SitSansStatusEntities SitSansStatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
        public ICollection<TicketEntities> Tickets { get; set; }
    }
}
