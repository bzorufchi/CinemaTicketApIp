namespace CinemaTicket.Entities
{
    public class MovieDetailEntities
    {
        public int Id { get; set; }
        public MovieEntities MovieId { get; set; }
        public MovieDetailKeyEntities MovieDetailKeyId { get; set; }
        public string Value { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
