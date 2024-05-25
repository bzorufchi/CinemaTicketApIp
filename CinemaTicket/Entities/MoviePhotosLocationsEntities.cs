namespace CinemaTicket.Entities
{
    public class MoviePhotosLocationsEntities
    {
        public int Id { get; set; }
        public MovieEntities MovieId { get; set; }
        public string Path { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
