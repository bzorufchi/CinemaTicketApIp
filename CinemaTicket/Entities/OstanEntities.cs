namespace CinemaTicket.Entities
{
    public class OstanEntities
    {
        public int Id { get; set; }
        public string OstanName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
        public ICollection<CityEntities> Cities { get; set; }
    }
}
