namespace CinemaTicket.Entities
{
    public class UserQuestionAnswerEntities
    {
        public int Id { get; set; }
        public RateEntities RateId { get; set; }
        public UserEntities UserId { get; set; }
        public CinemaEntities CinemaId { get; set; }
        public int Value { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
    }
}
