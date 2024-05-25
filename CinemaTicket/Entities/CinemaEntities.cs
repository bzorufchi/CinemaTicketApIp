namespace CinemaTicket.Entities
{
    public class CinemaEntities
    {
        public int Id { get; set; }
        public CityEntities CityId { get; set; }
        public string CinemaName { get; set; }
        public string Address { get; set; }
        public string MainPhoto { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        // Location is set to string
        // Should set to geometry
        public string Location { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }
    }
}
