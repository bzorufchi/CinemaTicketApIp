namespace CinemaTicket.Entities
{
    public class TicketStatusEntities
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
        public ICollection<TicketEntities> Tickets { get; set; }
    }
}
