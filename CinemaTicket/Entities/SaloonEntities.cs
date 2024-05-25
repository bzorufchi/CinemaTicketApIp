namespace CinemaTicket.Entities
{
    public class SaloonEntities
    {
        public int Id { get; set; }
        public string SaloonName { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public int NumberOfRows { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
