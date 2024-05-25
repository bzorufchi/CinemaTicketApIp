namespace CinemaTicket.Entities
{
    public class SitSansStatusEntities
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
