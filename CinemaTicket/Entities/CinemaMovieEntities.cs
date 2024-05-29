namespace CinemaTicket.Entities
{
    public class CinemaMovieEntities
    {
        public int Id { get; set; }
        public MovieEntities MovieId { get; set; }
        public CinemaEntities CinemaId { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
