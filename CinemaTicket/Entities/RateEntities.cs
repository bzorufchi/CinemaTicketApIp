namespace CinemaTicket.Entities
{
    public class RateEntities
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public float Weight { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
