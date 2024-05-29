namespace CinemaTicket.Entities
{
    public class CategoryEntities
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
        public ICollection<MovieEntities> Movies { get; set; }
    }
}
