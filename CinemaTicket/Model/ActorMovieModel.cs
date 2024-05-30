namespace CinemaTicket.Model
{
    public class ActorMovieModel
    {
       public class ActorMovieInput
        {
            public int Id { get; set; }
        }
        public class ActorMovieOutput : ActorMovieInput {
            public int MovieId { get; set; }
            public int ActorId { get; set; }
            public DateTime CreateDate { get; set; }
            public int Isactive { get; set; }
            public int ByUserId { get; set; }
        }
    }
}
