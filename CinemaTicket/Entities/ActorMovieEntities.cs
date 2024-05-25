namespace CinemaTicket.Entities
{
    public class ActorMovieEntities
    {
        public int Id { get; set; }
        public MovieEntities MovieId { get; set; }
        public ActorEntities ActorId { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
