namespace CinemaTicket.Entities
{
    public class UserRateAverageEntities
    {
        public int Id { get; set; }
        public UserEntities UserId { get; set; }
        public CinemaEntities CinemaId { get; set; }
        public float Average { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
    }
}
