namespace CinemaTicket.Model
{
    public class CinemaModel
    {
       public class CinemaInput
        {
            public int Id { get; set; }
        }
        public class CinemaOutput: CinemaInput
        {
            public int CityId { get; set; }
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
        public class AddCinemaInputModel {
            public int CityId { get; set; }
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
}
