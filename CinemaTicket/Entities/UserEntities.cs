namespace CinemaTicket.Entities
{
    public class UserEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserDetail { get; set; }
        public DateTime CreateDate { get; set; }
        public int Isactive { get; set; }
        public int ByUserId { get; set; }

    }
}
