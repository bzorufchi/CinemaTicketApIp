namespace CinemaTicket.Entities
{
    public class SansEntities
    {
        public int Id { get; set; }
        public SansTimeEntities SansTimeId { get; set; }
        public MovieEntities MovieId { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public float Percent { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
