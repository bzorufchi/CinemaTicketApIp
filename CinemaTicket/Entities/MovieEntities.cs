namespace CinemaTicket.Entities
{
    public class MovieEntities
    {
        public int Id { get; set; }
        public GenreEntities GenreId { get; set; }
        public AgeGroupEntities AgeGroupId { get; set; }
        public MovieStatusEntities StatusId { get; set; }
        public CategoryEntities CategoryId { get; set; }
        public string CinemaName { get; set; }
        public string MainPhoto { get; set; }
        public string Description { get; set; }
        // Director
        public string Teaser { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
