namespace CinemaTicket.Entities
{
    public class SitEntities
    {
        public int Id { get; set; }
        public SitStatusEntities SitStatusId { get; set; }
        public SaloonEntities SaloonId { get; set; }
        public int Numebr { get; set; }
        public int Row { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
