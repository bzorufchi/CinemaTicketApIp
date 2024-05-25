namespace CinemaTicket.Entities
{
    public class SitStatusEntities
    {
        public int Id { get; set; }
        public string SitStatusName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
