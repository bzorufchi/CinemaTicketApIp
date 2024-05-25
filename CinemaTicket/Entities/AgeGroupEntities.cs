namespace CinemaTicket.Entities
{
    public class AgeGroupEntities
    {
        public int Id { get; set; }
        public string AgeGroupName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
