namespace CinemaTicket.Entities
{
    public class MovieDetailKeyEntities
    {
        public int Id { get; set; }
        public string MovieDetailKeyName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
        public ICollection<MovieDetailEntities> MovieDetails { get; set; }
    }
}
