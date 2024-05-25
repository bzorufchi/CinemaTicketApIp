namespace CinemaTicket.Entities
{
    public class CityEntities
    {
        public int Id { get; set; }
        public OstanEntities OstanId { get; set; }
        public string CityName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
