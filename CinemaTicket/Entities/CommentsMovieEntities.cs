namespace CinemaTicket.Entities
{
    public class CommentsMovieEntities
    {
        public int Id { get; set; }
        public MovieEntities MovieId { get; set; }
        public UserEntities UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
