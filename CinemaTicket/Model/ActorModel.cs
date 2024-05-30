namespace CinemaTicket.Model
{
    public class ActorModel
    {
      public class ActorModelInput
        {
            public int Id { get; set; }
        }
        public class ActoreModelOutput : ActorModel
        {
            public string ActorName { get; set; }
            public DateTime Birthday { get; set; }
            public string Photo { get; set; }
            public string Description { get; set; }
            public string Detail { get; set; }
            public int ByUserId { get; set; }
            public int Isactive { get; set; }
            public DateTime CreateDate { get; set; }
        }

    }
}
