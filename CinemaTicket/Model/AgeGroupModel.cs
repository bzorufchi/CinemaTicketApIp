namespace CinemaTicket.Model
{
    public class AgeGroupModel
    {
      public class AgeGroupInput
        {
            public int Id { get; set; }
        }
        public class AgeGroupOutput: AgeGroupInput {
            public string AgeGroupName { get; set; }
            public DateTime CreateDate { get; set; }
            public int Isactive { get; set; }
            public int ByUserId { get; set; }
        }
    }
}
